using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Forms
{
    public partial class frmDodavanjeVozila : Form
    {
        private readonly string connString = Properties.Settings.Default.connString;
        String base64Img;

        public frmDodavanjeVozila()
        {
            InitializeComponent();
        }

        private void pboxSlika_Click(object sender, EventArgs e)
        {
            byte[] imgBytes;
            Image img;
            base64Img = GetImageBase64();
            if (base64Img != "")
            {
                imgBytes = Convert.FromBase64String(base64Img);
                using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);
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

                string queryString = $"INSERT INTO Vozila (Marka, Model, Kubikaza, Snaga, Brzina, NulaDoSto, CijenaDan, Slika) " +
                    $"VALUES (@marka, @model, @kubikaza, @snaga, @brzina, @nulaDoSto, @cijenaDan, @slika)";
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand command = new SqlCommand(queryString, conn);
                command.Parameters.AddWithValue("@marka", marka);
                command.Parameters.AddWithValue("@model", model);
                command.Parameters.AddWithValue("@kubikaza", kubikaza);
                command.Parameters.AddWithValue("@snaga", snaga);
                command.Parameters.AddWithValue("@brzina", brzina);
                command.Parameters.AddWithValue("@nulaDoSto", nulaDoSto);
                command.Parameters.AddWithValue("@cijenaDan", cijenaDan);
                command.Parameters.AddWithValue("@slika", slika);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Provjerite format unosa brojcanih vrijednosti ili popunite sva polja", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetImageBase64()
        {
            string base64Image = "";
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { InitialDirectory = Directory.GetCurrentDirectory(), Filter = "Image Files|*.jpg;*.jpeg;*.png" })
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
