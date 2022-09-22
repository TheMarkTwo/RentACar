using RentACar.DBModel;
using RentACar.Model;

namespace RentACar.Forms
{
    public partial class frmDodavanjeVozila : Form
    {
        readonly DBComms dbc = new();
        String base64Img;

        bool uredivanje = false;
        Vozilo v;

        public frmDodavanjeVozila()
        {
            InitializeComponent();
        }

        public frmDodavanjeVozila(Vozilo _v)
        {
            uredivanje = true;
            v = _v;
            InitializeComponent();
        }

        private void frmDodavanjeVozila_Load(object sender, EventArgs e)
        {
            if (uredivanje)
            {
                lblNaslov.Text = "Uredivanje vozila";
                this.Text = "Uredivanje vozila";
                txtMarka.Text = v.Marka;
                txtModel.Text = v.Model;
                txtSnaga.Text = v.Snaga.ToString();
                txtKubikaza.Text = v.Kubikaza.ToString();
                txtBrzina.Text = v.Brzina.ToString();
                txtNulaDoSto.Text = v.NulaDoSto.ToString();
                txtCijenaDan.Text = v.CijenaDan.ToString();
                base64Img = v.Slika;
                using MemoryStream ms = new(Convert.FromBase64String(v.Slika)); pboxSlika.Image = Image.FromStream(ms);
            }
        }

        private void pboxSlika_Click(object sender, EventArgs e)
        {
            byte[] imgBytes;
            Image img;
            base64Img = GetImageBase64();
            if (base64Img != "")
            {
                imgBytes = Convert.FromBase64String(base64Img);
                using (MemoryStream ms = new(imgBytes)) img = Image.FromStream(ms);
                pboxSlika.Image = img;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                if (string.IsNullOrEmpty(marka) || string.IsNullOrEmpty(model))
                {
                    MessageBox.Show("Provjerite format unosa brojcanih vrijednosti ili popunite sva polja", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                decimal kubikaza = decimal.Parse(txtKubikaza.Text);
                int snaga = int.Parse(txtSnaga.Text);
                int brzina = int.Parse(txtBrzina.Text);
                decimal nulaDoSto = decimal.Parse(txtNulaDoSto.Text);
                decimal cijenaDan = decimal.Parse(txtCijenaDan.Text);
                string slika = base64Img;
                Vozilo voz = new(marka, model, kubikaza, snaga, brzina, nulaDoSto, cijenaDan, slika);
                if (uredivanje)
                    voz.ID = v.ID;
                dbc.SpremiVozilo(voz, uredivanje);
                MessageBox.Show("Uspjesno ste spremili vozilo", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Popunite sva polja ili provjerite format unosa brojcanih vrijednosti", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetImageBase64()
        {
            string base64Image = "";
            using (OpenFileDialog openFileDialog = new() { InitialDirectory = Directory.GetCurrentDirectory(), Filter = "Image Files|*.jpg;*.jpeg;*.png" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] imageArray = File.ReadAllBytes(openFileDialog.FileName);
                    base64Image = Convert.ToBase64String(imageArray);
                }
                else base64Image = "";
            }
            return base64Image;
        }
    }
}
