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
        readonly SqlConnection conn = new(Properties.Settings.Default.connString);

        // VOZILA
        public Vozilo DohvatiVozilo(int id)
        {
            SqlCommand command = new($"SELECT * FROM Vozila WHERE ID = @id", conn);
            command.Parameters.AddWithValue("@id", id);
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

        public void SpremiVozilo(Vozilo v, bool uredivanje)
        {
            string queryString;
            if (uredivanje)
            {
                queryString = $"UPDATE Vozila " +
                    $"SET Marka = @marka, Model = @model, Kubikaza = @kubikaza, Snaga = @snaga, " +
                    $"Brzina = @brzina, NulaDoSto = @nulaDoSto, CijenaDan = @cijenaDan, Slika = @slika " +
                    $"WHERE ID = @id";
            }
            else
            {
                queryString = $"INSERT INTO Vozila (Marka, Model, Kubikaza, Snaga, Brzina, NulaDoSto, CijenaDan, Slika) " +
                    $"VALUES (@marka, @model, @kubikaza, @snaga, @brzina, @nulaDoSto, @cijenaDan, @slika)";
            }
            SqlCommand command = new SqlCommand(queryString, conn);
            command.Parameters.AddWithValue("@id", v.ID);
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
            SqlCommand command = new($"DELETE FROM Vozila WHERE ID = @id", conn);
            command.Parameters.AddWithValue("@id", id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Vozilo> UcitajVozila(string queryString)
        {
            List<Vozilo> lista = new();
            SqlCommand command = new(queryString, conn);
            conn.Open();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Vozilo v = new()
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
                    lista.Add(v);
                }
            }
            conn.Close();
            return lista;
        }

        //KUPCI
        public Kupac DohvatiKupca(string oib)
        {
            SqlCommand command = new($"SELECT * FROM Kupci WHERE OIB = @oib", conn);
            command.Parameters.AddWithValue("@oib", oib);
            Kupac k = new();
            conn.Open();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    k.OIB = dr.GetString(0);
                    k.Ime = dr.GetString(1);
                    k.Prezime = dr.GetString(2);
                    k.Broj = dr.GetString(3);
                    k.Email = dr.GetString(4);
                }
            }
            conn.Close();
            return k;
        }

        public void SpremiKupca(Kupac k)
        {
            string queryString = "INSERT INTO Kupci(OIB, Ime, Prezime, Broj, Email) " +
                "VALUES (@oib, @ime, @prezime, @broj, @email)";
            SqlCommand command = new(queryString, conn);
            command.Parameters.AddWithValue("@oib", k.OIB);
            command.Parameters.AddWithValue("@ime", k.Ime);
            command.Parameters.AddWithValue("@prezime", k.Prezime);
            command.Parameters.AddWithValue("@broj", k.Broj);
            command.Parameters.AddWithValue("@email", k.Email);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
        
        public void IzbrisiKupca(string oib)
        {
            SqlCommand command = new($"DELETE FROM Kupci WHERE OIB = @oib", conn);
            command.Parameters.AddWithValue("@oib", oib);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Kupac> UcitajKupce(string queryString)
        {
            List<Kupac> lista = new();
            SqlCommand command = new(queryString, conn);
            conn.Open();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Kupac k = new()
                    {
                        OIB = dr.GetString(0),
                        Ime = dr.GetString(1),
                        Prezime = dr.GetString(2),
                        Broj = dr.GetString(3),
                        Email = dr.GetString(4)
                    };
                    lista.Add(k);
                }
            }
            conn.Close();
            return lista;
        }

        //NAJMOVI
        public void SpremiNajam(Najam n)
        {
            string queryString = "INSERT INTO Najmovi(ID_vozila, OIB_kupca, DatumNajma, DatumKraja, Cijena) " +
                "VALUES (@ID_vozila, @OIB_kupca, @datumNajma, @datumKraja, @cijena)";
            SqlCommand command = new(queryString, conn);
            command.Parameters.AddWithValue("@ID_vozila", n.ID_vozila);
            command.Parameters.AddWithValue("@OIB_kupca", n.OIB_kupca);
            command.Parameters.AddWithValue("@datumNajma", n.DatumNajma.ToString());
            command.Parameters.AddWithValue("@datumKraja", n.DatumKraja.ToString());
            command.Parameters.AddWithValue("@cijena", n.Cijena);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void IzbrisiNajam(int id)
        {
            SqlCommand command = new($"DELETE FROM Najmovi WHERE ID = @id", conn);
            command.Parameters.AddWithValue("@id", id);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Najam> UcitajNajmove(string queryString)
        {
            List<Najam> lista = new();
            SqlCommand command = new(queryString, conn);
            conn.Open();
            using (SqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Najam n = new()
                    {
                        ID = dr.GetInt32(0),
                        ID_vozila = dr.GetInt32(1),
                        OIB_kupca = dr.GetString(2),
                        DatumNajma = DateOnly.FromDateTime(dr.GetDateTime(3)),
                        DatumKraja = DateOnly.FromDateTime(dr.GetDateTime(4)),
                        Cijena = dr.GetInt32(5)
                    };
                    lista.Add(n);
                }
            }
            conn.Close();
            return lista;
        }
    }
}
