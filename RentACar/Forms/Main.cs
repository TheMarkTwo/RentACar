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
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        private void iznajmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIznajmi izn = new frmIznajmi();
            izn.ShowDialog();
        }

        private void vozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozila voz = new frmVozila();
            voz.ShowDialog();
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
    }
}
