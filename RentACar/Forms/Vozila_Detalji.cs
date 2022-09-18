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
    public partial class frmDetaljiVozila : Form
    {
        Vozilo v;
        public frmDetaljiVozila(Vozilo _v)
        {
            v = _v;
            InitializeComponent();
        }

        private void frmDetaljiVozila_Load(object sender, EventArgs e)
        {
            Image img;
            byte[] imgBytes = Convert.FromBase64String(v.Slika);
            using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
            pboxSlika.Image = img;
            lblNaziv.Text = $"{v.Marka} {v.Model}";
        }
    }
}
