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
        Kupac k;
        int brojDana;
        decimal cijena;
        DBComms dbc = new();

        public frmIznajmi()
        {
            InitializeComponent();
        }

        private void frmIznajmi_Load(object sender, EventArgs e)
        {
            List<Vozilo> listaVozila = dbc.UcitajVozila("SELECT * FROM Vozila");
            foreach (Vozilo v in listaVozila)
                dgvVozila.Rows.Add(v.ID, $"{v.Marka} {v.Model}", $"{v.CijenaDan:0,0}€");
            dtpDatumOd.MinDate = DateTime.Today.AddDays(1);
        }

        private void dgvVozila_SelectionChanged(object sender, EventArgs e)
        {
            v = dbc.DohvatiVozilo(int.Parse(dgvVozila.CurrentRow.Cells[0].Value.ToString()));
            txtVozilo.Text = $"{v.Marka} {v.Model}";
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
            //napravi cheking za podatke
        }

        public void OsvjeziCijenu()
        {
            brojDana = (int)(dtpDatumDo.Value - dtpDatumOd.Value).Days;
            if (brojDana < 4)
                cijena = v.CijenaDan * brojDana;
            else if (brojDana < 8)
                cijena = v.CijenaDan * (decimal)0.9 * brojDana;
            else
                cijena = v.CijenaDan * (decimal)0.8 * brojDana;

            lblBrojDana.Text = "Broj dana: " + brojDana.ToString();
            lblCijena.Text = $"Cijena: {cijena:0,0}€";
        }
    }
}
