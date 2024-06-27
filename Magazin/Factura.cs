using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Magazin
{
    public partial class Factura : Form
    {
        private Utilizator utilizatorCurent;
        private Random random;
        public Factura()
        {
            random = new Random();
            InitializeComponent();
            LoadDataFromXml();
            LoadComenziData();
            LoadFurnizoriData();
            LoadClientData();


            int randomNumber = random.Next(1, 1111111);
            label5.Text = "Nr.Comanda: " + randomNumber.ToString() + "               " + DateTime.Now.ToString("dd-MM-yyyy   HH:mm:ss");
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
            dataTable.Columns.Add("Pret", typeof(decimal));
            dataTable.Columns.Add("Stoc", typeof(int));

            XmlNodeList produse = doc.GetElementsByTagName("produs");

            foreach (XmlNode produs in produse)
            {
                string cod = produs.SelectSingleNode("cod").InnerText;
                string denumire = produs.SelectSingleNode("denumire").InnerText;
                string descriere = produs.SelectSingleNode("descriere").InnerText;
                decimal pret = decimal.Parse(produs.SelectSingleNode("pret").InnerText);
                int stoc = int.Parse(produs.SelectSingleNode("stoc").InnerText);

                dataTable.Rows.Add(cod, denumire, descriere, pret, stoc);
            }

            // Setează DataSource pentru DataGridView pentru produse
            dataGridViewProduse.DataSource = dataTable;
            dataGridViewProduse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadComenziData()
        {
            DataTable comenziTable = new DataTable();
            comenziTable.Columns.Add("Denumire", typeof(string));
            comenziTable.Columns.Add("Cod", typeof(string));
            comenziTable.Columns.Add("Cantitate", typeof(int));
            comenziTable.Columns.Add("Pret Unitar", typeof(decimal));
            comenziTable.Columns.Add("TVA", typeof(decimal));
            comenziTable.Columns.Add("Total", typeof(decimal));

            string comenziFilePath = "comanda.txt"; // Înlocuiește cu calea fișierului tău de comenzi
            var comenzi = new Dictionary<string, (string Denumire, int Cantitate, decimal PretUnitar, decimal TVA, decimal Total)>();

            try
            {
                foreach (var line in File.ReadLines(comenziFilePath))
                {
                    var parts = line.Split('/');
                    if (parts.Length == 2)
                    {
                        string cod = parts[0].Trim();
                        int cantitate = int.Parse(parts[1].Trim());

                        decimal pretUnitar = 0;
                        decimal pretTotal = 0;
                        int stoc = 0;
                        string denumire = "";

                        // Caută produsul în DataTable-ul cu produse
                        DataRowView produsRowView = dataGridViewProduse.Rows.Cast<DataGridViewRow>()
                                                .Where(row => row.Cells["Cod"].Value.ToString() == cod)
                                                .FirstOrDefault()?.DataBoundItem as DataRowView;

                        if (produsRowView != null)
                        {
                            DataRow produsRow = produsRowView.Row;
                            denumire = produsRow["Denumire"].ToString();
                            pretUnitar = (decimal)produsRow["Pret"];
                            stoc = (int)produsRow["Stoc"];
                        }

                        decimal tva = pretUnitar * cantitate * 0.19m; // TVA 19%
                        pretTotal = (pretUnitar * cantitate) + tva;

                        if (comenzi.ContainsKey(cod))
                        {
                            var existing = comenzi[cod];
                            int newCantitate = existing.Cantitate + cantitate;
                            decimal newTva = existing.TVA + tva;
                            decimal newTotal = existing.Total + pretTotal;
                            comenzi[cod] = (denumire, newCantitate, pretUnitar, newTva, newTotal);
                        }
                        else
                        {
                            comenzi[cod] = (denumire, cantitate, pretUnitar, tva, pretTotal);
                        }
                    }
                }

                // Adaugă datele din dicționar în DataTable pentru a le afișa în DataGridView
                foreach (var item in comenzi)
                {
                    comenziTable.Rows.Add(item.Value.Denumire, item.Key, item.Value.Cantitate, item.Value.PretUnitar, item.Value.TVA, item.Value.Total);
                }

                // Setează DataSource pentru DataGridView pentru comenzi
                dataGridViewProduse.DataSource = comenziTable;
                dataGridViewProduse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                decimal totalComanda = CalculateTotalOrder(comenziTable);
                labelCostTotal.Text = "Cost total:  " + totalComanda.ToString("N2");

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Fișierul de comenzi nu a fost găsit: {ex.Message}");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la citirea fișierului de comenzi: {ex.Message}");
                return;
            }

        }
        private decimal CalculateTotalOrder(DataTable comenziTable)
        {
            decimal total = 0;

            foreach (DataRow row in comenziTable.Rows)
            {
                total += (decimal)row["Total"];
            }

            return total;
        }



        private void LoadFurnizoriData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(" ", typeof(string));
            dataTable.Columns.Add("   ", typeof(string));

            string furnizoriFilePath = "furnizor.txt";
            try
            {

                var lines = File.ReadAllLines(furnizoriFilePath);
                if (lines.Length % 7 != 0)
                {
                    MessageBox.Show("Fișierul furnizor.txt nu are un număr corect de linii pentru furnizori.");
                    return;
                }


                for (int i = 0; i < lines.Length; i += 7)
                {
                    string nrReg = lines[i].Trim();
                    string cif = lines[i + 1].Trim();
                    string adresa = lines[i + 2].Trim();
                    string email = lines[i + 3].Trim();
                    string tel = lines[i + 4].Trim();
                    string banca = lines[i + 5].Trim();
                    string cont = lines[i + 6].Trim();

                    dataTable.Rows.Add("Nr. Reg.", nrReg);
                    dataTable.Rows.Add("CIF", cif);
                    dataTable.Rows.Add("Adresa", adresa);
                    dataTable.Rows.Add("Email", email);
                    dataTable.Rows.Add("Tel.", tel);
                    dataTable.Rows.Add("Banca", banca);
                    dataTable.Rows.Add("Cont", cont);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Fișierul de furnizori nu a fost găsit: {ex.Message}");
                return;
            }


            dataGridViewFurnizor.DataSource = dataTable;
            dataGridViewFurnizor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LoadClientData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(" ", typeof(string));
            dataTable.Columns.Add("  ", typeof(string));

            // Adaugă rândurile pentru clienți
            dataTable.Rows.Add("Nr. Reg.", string.Empty);
            dataTable.Rows.Add("CIF", string.Empty);
            dataTable.Rows.Add("Adresa", string.Empty);
            dataTable.Rows.Add("Email", string.Empty);
            dataTable.Rows.Add("Tel.", string.Empty);
            dataTable.Rows.Add("Banca", string.Empty);
            dataTable.Rows.Add("Cont", string.Empty);

            // Setează tabelul ca sursă de date pentru DataGridView
            dataGridViewClient.DataSource = dataTable;
            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Permite editarea celulelor din a doua coloană
            foreach (DataGridViewColumn column in dataGridViewClient.Columns)
            {
                column.ReadOnly = false; // Permite editarea ambelor coloane
            }

            // Setează prima coloană ca readonly
            dataGridViewClient.Columns[0].ReadOnly = true; // Prima coloană nu este editabilă
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Salvează factura ca imagine";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                SaveControlAsImage(this, saveFileDialog.FileName);

            }
        }
        private void SaveControlAsImage(Control control, string filePath)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bitmap, new Rectangle(0, 0, control.Width, control.Height));
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Capturează întregul formular ca imagine
                Bitmap bitmap = new Bitmap(this.Width, this.Height);
                this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

                // Salvează imaginea pentru a fi folosită în metoda PrintPage
                this.Tag = bitmap;

                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (this.Tag is Bitmap bitmap)
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
        }
    }


}



