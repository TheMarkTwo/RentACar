using RentACar.DBModel;
using RentACar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class frmIznajmi : Form
    {
        Vozilo v;
        Vozilo tempV = new();
        Kupac k = new();
        int brojDana;
        decimal cijena;
        DBComms dbc = new();

        public frmIznajmi()
        {
            InitializeComponent();
        }

        public frmIznajmi(Vozilo _v)
        {
            tempV = _v;
            InitializeComponent();
        }

        private void frmIznajmi_Load(object sender, EventArgs e)
        {
            
            List<Vozilo> listaVozila = dbc.UcitajVozila("SELECT * FROM Vozila");
            foreach (Vozilo voz in listaVozila)
                dgvVozila.Rows.Add(voz.ID, $"{voz.Marka} {voz.Model}", $"{voz.CijenaDan:0,0}€");
            dtpDatumOd.MinDate = DateTime.Today.AddDays(1);
            dgvVozila.CurrentRow.Selected = false;

            if (tempV.ID != null)
            {
                foreach (DataGridViewRow row in dgvVozila.Rows)
                {
                    if (int.Parse(row.Cells[0].Value.ToString()) == tempV.ID)
                    {
                        row.Cells[0].Selected = true;
                        OsvjeziOdabrani();
                        OsvjeziCijenu();
                        break;
                    }
                }
            }
        }

        private void dgvVozila_SelectionChanged(object sender, EventArgs e)
        {
            OsvjeziOdabrani();
            OsvjeziCijenu();
        }

        private void txtOIB_Leave(object sender, EventArgs e)
        {
            k = dbc.DohvatiKupca(txtOIB.Text);
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtBroj.Text = k.Broj;
            txtEmail.Text = k.Email;
        }

        private void dtpDatumOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDatumDo.MinDate = dtpDatumOd.Value.AddDays(1);
            OsvjeziCijenu();
        }

        private void dtpDatumDo_ValueChanged(object sender, EventArgs e)
        {
            OsvjeziCijenu();
        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtOIB.Text) && string.IsNullOrEmpty(txtIme.Text) && string.IsNullOrEmpty(txtPrezime.Text) && string.IsNullOrEmpty(txtBroj.Text) && string.IsNullOrEmpty(txtEmail.Text)))
            {
                if (k.OIB == null)
                {
                    k = new()
                    {
                        OIB = txtOIB.Text,
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Broj = txtBroj.Text,
                        Email = txtEmail.Text
                    };
                    dbc.SpremiKupca(k);
                }

                Najam n = new()
                {
                    ID_vozila = v.ID,
                    OIB_kupca = k.OIB,
                    DatumNajma = DateOnly.FromDateTime(dtpDatumOd.Value),
                    DatumKraja = DateOnly.FromDateTime(dtpDatumDo.Value),
                    Cijena = (int)cijena
                };
                dbc.SpremiNajam(n);

                MessageBox.Show("Uspjesno ste kreirali najam", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Popunite sva polja ili provjerite format unosa brojcanih vrijednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OsvjeziOdabrani()
        {
            v = dbc.DohvatiVozilo(int.Parse(dgvVozila.CurrentRow.Cells[0].Value.ToString()));
            txtVozilo.Text = $"{v.Marka} {v.Model}";
        }

        public void OsvjeziCijenu()
        {
            List<Najam> listaNajmova = dbc.UcitajNajmove($"SELECT * FROM Najmovi " +
                $"WHERE ID_vozila = {v.ID} AND " +
                $"DatumNajma < '{DateOnly.FromDateTime(dtpDatumOd.Value):yyyy-MM-dd}' AND DatumKraja > '{DateOnly.FromDateTime(dtpDatumOd.Value):yyyy-MM-dd}' OR " +
                $"DatumNajma < '{DateOnly.FromDateTime(dtpDatumDo.Value):yyyy-MM-dd}' AND DatumKraja > '{DateOnly.FromDateTime(dtpDatumDo.Value):yyyy-MM-dd}'");

            if (listaNajmova.Count > 0)
            {
                lblNedostupno.Visible = true;
                btnIznajmi.Enabled = false;
            }
            else
            {
                lblNedostupno.Visible = false;
                btnIznajmi.Enabled = true;
            }

            brojDana = (int)(dtpDatumDo.Value - dtpDatumOd.Value).Days;
            if (brojDana < 4)
                cijena = v.CijenaDan * brojDana;
            else if (brojDana < 8)
                cijena = v.CijenaDan * (decimal)0.9 * brojDana;
            else
                cijena = v.CijenaDan * (decimal)0.8 * brojDana;

            lblBrojDana.Text = "Broj dana: " + brojDana.ToString();
            //lblCijena.Text = $"Cijena: {cijena:0,0}€";
            lblCijena.Text = $"{v.ID}";
            //napravi cheking za slobodan datum
        }
    }
}
