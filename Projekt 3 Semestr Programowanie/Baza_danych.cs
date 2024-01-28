using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_Semestr_Programowanie
{
    internal class Baza_danych
    {
        private const string cs = "Server=DESKTOP-H2JDOS3;Database=Sklep Internetowy;Integrated Security=True; TrustServerCertificate=True";
        public static SqlConnection Polaczenie()
        {
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            return conn;
        }
        public static List<Klient> pobierz_klientow()
        {
            List<Klient> klienci = new List<Klient>();
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "select * from Klient";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int ID = Convert.ToInt32(reader["ID Klienta"]);
                            string Imie = reader["Imię"].ToString();
                            string Nazwisko = reader["Nazwisko"].ToString();
                            string Nr_telefonu = reader["Nr telefonu"].ToString();
                            string Kraj = reader["Kraj"].ToString();
                            string Miasto = reader["Miasto"].ToString();
                            string Ulica = reader["Ulica"].ToString();
                            string nr_budynku = reader["nr budynku"].ToString();

                            Klient k = new Klient(ID, Imie, Nazwisko, Nr_telefonu, Kraj, Miasto, Ulica, nr_budynku);

                            klienci.Add(k);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return klienci;
        }
        public static List<Produkt> pobierz_produkty()
        {
            List<Produkt> Produkty = new List<Produkt>();
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "select * from Produkt";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int ID_Produktu = Convert.ToInt32(reader["ID Produktu"]);
                            string Nazwa_Produktu = reader["Nazwa produktu"].ToString();
                            string Cena = reader["Cena"].ToString();
                            Produkt p = new Produkt(ID_Produktu, Nazwa_Produktu, Cena);
                            Produkty.Add(p);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Produkty;
        }
        public static List<Zamowienie> pobierz_zamowienia()
        {
            List<Zamowienie> Zamowienia = new List<Zamowienie>();
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "select * from Zamówienie z " +
                        "inner join [Szczegóły Zamowienia] sz on sz.[ID Zamowienia] = z.[ID zamowienia]";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int ID_zamowienia = Convert.ToInt32(reader["ID zamowienia"]);
                            int ID_klienta = Convert.ToInt32(reader["ID klienta"]);
                            string Data_zamowienia = reader["data zamowienia"].ToString();
                            int ID_produktu = Convert.ToInt32(reader["ID produktu"]);
                            string ilosc = reader["ilośc"].ToString();
                            Zamowienie z = new Zamowienie(ID_zamowienia, ID_klienta, Data_zamowienia, ID_produktu, ilosc);
                            Zamowienia.Add(z);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Zamowienia;
        }
        public static List<Dostawca> pobierz_dostawcow()
        {
            List<Dostawca> Dostawcy = new List<Dostawca>();
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "select * from Dostawca";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            int ID_dostawcy = Convert.ToInt32(reader["ID dostawcy"]);
                            string nazwa_firmy = reader["nazwa firmy"].ToString();
                            string Miasto = reader["Miasto"].ToString();
                            string ulica = reader["ulica"].ToString();
                            string nr_budynku = reader["nr budynku"].ToString();
                            string nr_telefonu = reader["nr telefonu"].ToString();
                            Dostawca d = new Dostawca(ID_dostawcy, nazwa_firmy, Miasto, ulica, nr_budynku, nr_telefonu);
                            Dostawcy.Add(d);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Dostawcy;
        }
        ///////////////////////////////////
        public static void dodawanie_produktu(int id, string nazwa, string cena)
        {
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "insert into Produkt([ID Produktu],[Nazwa produktu],Cena)" +
                        $"values (@id,@nazwa,@cena)";
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nazwa", nazwa);
                        command.Parameters.AddWithValue("@cena", cena);

                        MessageBox.Show("Ilość zaktualizowanych wierszy " + command.ExecuteNonQuery());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void usuwanie_produktu(int id)
        {
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string alterQuery = @"
                ALTER TABLE [dbo].[Szczegóły Zamowienia]
                DROP CONSTRAINT [FK_Szczegóły Zamowienia_Produkt];

                ALTER TABLE [dbo].[Szczegóły Zamowienia]
                ADD CONSTRAINT [FK_Szczegóły Zamowienia_Produkt]
                FOREIGN KEY ([ID produktu])
                REFERENCES [dbo].[Produkt]([ID produktu])
                ON DELETE CASCADE;
            ";

                    using (SqlCommand alterCommand = new SqlCommand(alterQuery, connection))
                    {
                        alterCommand.ExecuteNonQuery();
                    }

                    string deleteQuery = "DELETE FROM Produkt WHERE [ID Produktu] = @id";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", id);
                        MessageBox.Show("Ilość zaktualizowanych wierszy " + deleteCommand.ExecuteNonQuery());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void aktualizacja_ceny(int id, string cena)
        {
            try
            {
                using (SqlConnection connection = Polaczenie())
                {
                    string query = "update Produkt set Cena = @nowa where [ID Produktu] = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nowa", cena);
                        command.Parameters.AddWithValue("@id", id);
                        MessageBox.Show("Ilość zaktualizowanych wierszy " + command.ExecuteNonQuery());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}