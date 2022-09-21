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
        Kupac k;
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
        }

        private void dgvVozila_SelectionChanged(object sender, EventArgs e)
        {
            txtVozilo.Text = dgvVozila.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtOIB_Leave(object sender, EventArgs e)
        {
            k = dbc.DohvatiKupca(txtOIB.Text);
            txtIme.Text = k.Ime;
            txtPrezime.Text = k.Prezime;
            txtBroj.Text = k.Broj;
            txtEmail.Text = k.Email;
        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            //napravi cheking za podatke
        }
    }
}
