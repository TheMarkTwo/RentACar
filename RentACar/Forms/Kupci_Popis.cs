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
    public partial class frmKupci : Form
    {
        readonly DBComms dbc = new();

        public frmKupci()
        {
            InitializeComponent();
        }

        private void frmPopisKupaca_Load(object sender, EventArgs e)
        {
            dgvKupci.Rows.Clear();
            List<Kupac> lista = dbc.UcitajKupce("SELECT * FROM Kupci");
            foreach (Kupac k in lista)
                dgvKupci.Rows.Add(k.OIB, k.Ime, k.Prezime, k.Broj, k.Email);
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                DialogResult dialogres = MessageBox.Show("Jeste li sigurni da zelite obrisati ovog kupca?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogres == DialogResult.Yes)
                {
                    dbc.IzbrisiKupca(dgvKupci.CurrentRow.Cells[0].Value.ToString());
                    dgvKupci.Rows.RemoveAt(dgvKupci.SelectedRows[0].Index);
                }
            }
        }
    }
}
