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

namespace RentACar.Forms
{
    public partial class frmVozila : Form
    {
        private readonly string connString = Properties.Settings.Default.connString;

        public frmVozila()
        {
            InitializeComponent();
        }

        private void frmVozila_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Vozila", conn);
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Vozilo v = new Vozilo()
                    {
                        ID = dr.GetInt32(0),
                        Marka = dr.GetString(1),
                        Model = dr.GetString(2),
                        Kubikaza = dr.GetDecimal(3),
                        Snaga = dr.GetInt32(4),
                        Brzina = dr.GetInt32(5),
                        NulaDoSto = dr.GetDecimal(6),
                        CijenaDan = dr.GetDecimal(7),
                        Slika = dr.GetString(8)
                    };
                    Image img;
                    byte[] imgBytes = Convert.FromBase64String(v.Slika);
                    using (MemoryStream ms = new MemoryStream(imgBytes)) img = Image.FromStream(ms);

                    dgvVozila.Rows.Add(v.ID, img, $"{v.Marka} {v.Model}", $"{v.Snaga}PS", $"{v.Brzina}km/h", $"{v.NulaDoSto}s", $"{v.CijenaDan:0,0}€");
                }
            }
            conn.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodavanjeVozila dodvoz = new frmDodavanjeVozila();
            dodvoz.ShowDialog();
        }
    }
}
