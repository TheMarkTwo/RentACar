using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RentACar.Model;

namespace RentACar.DBModel
{
    internal class DBComms
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString);

        // VOZILA
        public Vozilo DohvatiVozilo(int id)
        {
            SqlCommand command = new SqlCommand($"SELECT * FROM Vozila WHERE ID = {id}", conn);
            Vozilo v = new();
            conn.Open();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    v.ID = dr.GetInt32(0);
                    v.Marka = dr.GetString(1);
                    v.Model = dr.GetString(2);
                    v.Kubikaza = dr.GetDecimal(3);
                    v.Snaga = dr.GetInt32(4);
                    v.Brzina = dr.GetInt32(5);
                    v.NulaDoSto = dr.GetDecimal(6);
                    v.CijenaDan = dr.GetDecimal(7);
                    v.Slika = dr.GetString(8);
                }
            }
            conn.Close();
            return v;
        }

        public void UcitajVozila(DataGridView dgv, string queryString)
        {
            dgv.Rows.Clear();
            SqlCommand command = new SqlCommand(queryString, conn);
            conn.Open();
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

                    dgv.Rows.Add(v.ID, img, $"{v.Marka} {v.Model}", $"{v.Snaga}PS", $"{v.Brzina}km/h", $"{v.NulaDoSto}s", $"{v.CijenaDan:0,0}€");
                }
            }
            conn.Close();
        }

        public void SpremiVozilo(Vozilo v)
        {
            string queryString = $"INSERT INTO Vozila (Marka, Model, Kubikaza, Snaga, Brzina, NulaDoSto, CijenaDan, Slika) " +
                $"VALUES (@marka, @model, @kubikaza, @snaga, @brzina, @nulaDoSto, @cijenaDan, @slika)";
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("@marka", v.Marka);
            command.Parameters.AddWithValue("@model", v.Model);
            command.Parameters.AddWithValue("@kubikaza", v.Kubikaza);
            command.Parameters.AddWithValue("@snaga", v.Snaga);
            command.Parameters.AddWithValue("@brzina", v.Brzina);
            command.Parameters.AddWithValue("@nulaDoSto", v.NulaDoSto);
            command.Parameters.AddWithValue("@cijenaDan", v.CijenaDan);
            command.Parameters.AddWithValue("@slika", v.Slika);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void IzbrisiVozilo(int id)
        {
            string queryString = $"DELETE FROM Vozila WHERE ID = {id}";
            SqlCommand command = new SqlCommand(queryString, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        //KUPCI

        //NAJMOVI
    }
}
