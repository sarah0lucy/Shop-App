using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Magazin
{
    public partial class Cos : Form
    {
        public Cos()
        {
            InitializeComponent();
            LoadDataFromXml();
        }

        private void LoadDataFromXml()
        {
            string xmlFilePath = "depozit.xml"; // Înlocuiește cu calea fișierului tău XML
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFilePath);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Cod", typeof(string));
            dataTable.Columns.Add("Denumire", typeof(string));
            dataTable.Columns.Add("Descriere", typeof(string));
            dataTable.Columns.Add("Pret", typeof(string));
            dataTable.Columns.Add("Stoc", typeof(string));
            dataTable.Columns.Add("Cantitate", typeof(string)); // Coloană pentru cantitate

            // Citește fișierul de comenzi și stochează codurile și cantitățile într-un dicționar
            string ordersFilePath = "comanda.txt"; // Înlocuiește cu calea fișierului tău de comenzi
            var orders = new Dictionary<string, string>();
            foreach (var line in File.ReadLines(ordersFilePath))
            {
                var parts = line.Split('/');
                if (parts.Length == 2)
                {
                    string cod = parts[0].Trim();
                    string cantitate = parts[1].Trim();
                    orders[cod] = cantitate;
                }
            }

            XmlNodeList produse = doc.GetElementsByTagName("produs");

            foreach (XmlNode produs in produse)
            {
                string cod = produs.SelectSingleNode("cod").InnerText;
                string denumire = produs.SelectSingleNode("denumire").InnerText;
                string descriere = produs.SelectSingleNode("descriere").InnerText;
                string pret = produs.SelectSingleNode("pret").InnerText;
                string stoc = produs.SelectSingleNode("stoc").InnerText;

                if (orders.ContainsKey(cod))
                {
                    string cantitate = orders[cod];
                    dataTable.Rows.Add(cod, denumire, descriere, pret, stoc, cantitate);
                }
            }

            // Setează DataSource pentru DataGridView
            dataGridView1.DataSource = dataTable;

            // (Opțional) Auto-size columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ButonFactura_Click(object sender, EventArgs e)
        {
            Factura form2 = new Factura();
            form2.Show();
            this.Hide();
        }

        private void Cos_Load(object sender, EventArgs e)
        {

        }
    }
}


