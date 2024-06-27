using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace Magazin
{
    public class Depozit
    {
        private readonly string _connectionString;

        public Depozit(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void ImportDataFromXml(string filePath)
        {
            try
            {
                // Încarcă fișierul XML
                XDocument doc = XDocument.Load(filePath);

                // Deschide conexiunea la baza de date
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();

                    // Iterează prin fiecare element <produs> din XML
                    foreach (XElement produs in doc.Descendants("produs"))
                    {
                        string cod = produs.Element("cod").Value;
                        string denumire = produs.Element("denumire").Value;
                        string descriere = produs.Element("descriere").Value;
                        string pret = produs.Element("pret").Value;
                        string stoc = produs.Element("stoc").Value;

                        // Creează și execută comanda SQL pentru a insera datele în baza de date
                        string query = "INSERT INTO produse (cod, denumire, descriere, pret, stoc) VALUES (@cod, @denumire, @descriere, @pret, @stoc)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@cod", cod);
                            cmd.Parameters.AddWithValue("@denumire", denumire);
                            cmd.Parameters.AddWithValue("@descriere", descriere);
                            cmd.Parameters.AddWithValue("@pret", pret);
                            cmd.Parameters.AddWithValue("@stoc", stoc);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                Console.WriteLine("Importul datelor din XML în baza de date a fost realizat cu succes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("A apărut o eroare în timpul importului: " + ex.Message);
            }
        }
    }
}