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
    public partial class frmMain : Form
    {
        DBComms dbc = new();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OsvjeziNajmove();
        }

        private void iznajmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIznajmi izn = new();
            izn.ShowDialog();
            OsvjeziNajmove();
        }

        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozila voz = new();
            voz.ShowDialog();
            OsvjeziNajmove();
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKupci kup = new();
            kup.ShowDialog();
        }

        private void cboxPretragaDatum_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPretragaDatum.Checked)
            {
                dtpDatumDo.Enabled = true;
                dtpDatumDo.CustomFormat = "dd.MM.yyyy";
                dtpDatumOd.Enabled = true;
                dtpDatumOd.CustomFormat = "dd.MM.yyyy";
            }
            else
            {
                dtpDatumDo.Enabled = false;
                dtpDatumDo.CustomFormat = " ";
                dtpDatumOd.Enabled = false;
                dtpDatumOd.CustomFormat = " ";
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgvNajmovi.SelectedRows.Count > 0)
            {
                DialogResult dialogres = MessageBox.Show("Jeste li sigurni da zelite obrisati ovaj najam?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogres == DialogResult.Yes)
                {
                    dbc.IzbrisiNajam(int.Parse(dgvNajmovi.CurrentRow.Cells[0].Value.ToString()));
                    dgvNajmovi.Rows.RemoveAt(dgvNajmovi.SelectedRows[0].Index);
                }
            }
        }

        public void OsvjeziNajmove()
        {
            dgvNajmovi.Rows.Clear();
            List<Najam> listaNajmova = dbc.UcitajNajmove("SELECT * FROM Najmovi");
            foreach (Najam n in listaNajmova)
            {
                Vozilo v = dbc.DohvatiVozilo(n.ID_vozila);
                dgvNajmovi.Rows.Add(n.ID, $"{v.Marka} {v.Model}", n.OIB_kupca, n.DatumNajma.ToString("dd.MM.yyy"), n.DatumKraja.ToString("dd.MM.yyy"), $"{n.Cijena:0,0}€");
            }
        }
    }
}
