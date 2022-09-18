using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentACar.Model;
using RentACar.DBModel;

namespace RentACar.Forms
{
    public partial class frmVozila : Form
    {
        private readonly string connString = Properties.Settings.Default.connString;
        DBComms dbc = new();

        public frmVozila()
        {
            InitializeComponent();
        }
        private void dgvVozila_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vozilo v = dbc.DohvatiVozilo(int.Parse(dgvVozila.Rows[e.RowIndex].Cells[0].Value.ToString()));
            frmDetaljiVozila detv = new(v);
            detv.Show();
        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            dbc.UcitajVozila(dgvVozila, "SELECT * FROM Vozila");
        }
        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeVozila dodvoz = new frmDodavanjeVozila();
            dodvoz.ShowDialog();
            dbc.UcitajVozila(dgvVozila, "SELECT * FROM Vozila");
        }
        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeVozila dodvoz = new frmDodavanjeVozila(new Vozilo());
            dodvoz.ShowDialog();
            dbc.UcitajVozila(dgvVozila, "SELECT * FROM Vozila");
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count > 0)
            {
                DialogResult dialogres = MessageBox.Show("Jeste li sigurni da zelite obrisati ovo vozilo?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogres == DialogResult.Yes)
                {
                    int id = int.Parse(dgvVozila.CurrentRow.Cells[0].Value.ToString());
                    dgvVozila.Rows.RemoveAt(dgvVozila.SelectedRows[0].Index);
                    dbc.IzbrisiVozilo(id);
                }
            }
        }
    }
}
