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
        readonly DBComms dbc = new();

        public frmVozila()
        {
            InitializeComponent();
        }
        private void frmVozila_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void dgvVozila_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vozilo v = dbc.DohvatiVozilo(int.Parse(dgvVozila.Rows[e.RowIndex].Cells[0].Value.ToString()));
            frmDetaljiVozila detv = new(v);
            detv.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeVozila dodvoz = new frmDodavanjeVozila();
            dodvoz.ShowDialog();
            OsvjeziPopis();
        }

        private void urediToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeVozila dodvoz = new frmDodavanjeVozila(dbc.DohvatiVozilo(int.Parse(dgvVozila.CurrentRow.Cells[0].Value.ToString())));
            dodvoz.ShowDialog();
            OsvjeziPopis();
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count > 0)
            {
                DialogResult dialogres = MessageBox.Show("Jeste li sigurni da zelite obrisati ovo vozilo?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogres == DialogResult.Yes)
                {
                    dbc.IzbrisiVozilo(int.Parse(dgvVozila.CurrentRow.Cells[0].Value.ToString()));
                    dgvVozila.Rows.RemoveAt(dgvVozila.SelectedRows[0].Index);
                }
            }
        }

        public void OsvjeziPopis()
        {
            dgvVozila.Rows.Clear();
            List<Vozilo> lista = dbc.UcitajVozila("SELECT * FROM Vozila");
            foreach (Vozilo v in lista)
            {
                Image img;
                byte[] imgBytes = Convert.FromBase64String(v.Slika);
                using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);

                dgvVozila.Rows.Add(v.ID, img, $"{v.Marka} {v.Model}", $"{v.Snaga}PS", $"{v.Brzina}km/h", $"{v.NulaDoSto}s", $"{v.CijenaDan:0,0}€");
            }
        }
    }
}
