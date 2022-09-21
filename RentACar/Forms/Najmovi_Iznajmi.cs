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
    }
}
