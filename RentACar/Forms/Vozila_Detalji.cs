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
            lblSnaga.Text = v.Snaga + " PH";
            lblKubikaza.Text = $"{v.Kubikaza:0,0} cc";
            lblBrzina.Text = v.Brzina + " km/h";
            lblNulaDoSto.Text = v.NulaDoSto + " s";

            lblCijena1.Text = $"{(double)v.CijenaDan:0,0} € dan";
            lblCijena2.Text = $"{((double)v.CijenaDan * 0.90):0,0} € dan";
            lblCijena3.Text = $"{((double)v.CijenaDan * 0.80):0,0} € dan";
        }
    }
}
