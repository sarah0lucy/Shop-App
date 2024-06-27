using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QRCoder;


namespace Magazin
{

    public partial class Home : Form
    {

        private Utilizator utilizatorCurent;

        private string filePath = "comanda.txt";

        private static int nextBarcodeId = 1;


        public Home(Utilizator utilizator)
        {
            InitializeComponent();
            utilizatorCurent = utilizator;
            AfiseazaCodUnic();


            ButonFactura.Visible = false;

            ComandaText.Visible = false;
            ButonTrimite.Visible = false;
            ButonCos.Visible = false;
           


            textBox1.Visible = false;
            button1.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void AfiseazaCodUnic()
        {
            ID.Text = "id Client: " + utilizatorCurent.IdClient;
        }






        private void ButonComanda_Click(object sender, EventArgs e)
        {
            ComandaText.Visible = true;
            ButonTrimite.Visible = true;
            ButonCos.Visible = true;

            textBox1.Visible = false;
            button1.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;
            label1.Visible = false;
            pictureBox1.Visible = false;

        }

        private void ButonTrimite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, ComandaText.Text);
            MessageBox.Show("Fișierul a fost salvat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ButonCos_Click(object sender, EventArgs e)
        {
            Cos form2 = new Cos();
            form2.Show();
            this.Hide();
        }
        private void ButonFactura_Click(object sender, EventArgs e)
        {

        }














        //////////////////////////////// ////////////////////

        private void ButonStoc_Click(object sender, EventArgs e)
        {
            ComandaText.Visible = false;
            ButonTrimite.Visible = false;
            ButonCos.Visible = false;

            textBox1.Visible = true;
            button1.Visible = true;
            listBox1.Visible = true;
            listBox2.Visible = true;
            label1.Visible = true;
            pictureBox1.Visible = true;
            string filePath = "calea_catre_depozit.xml"; // Înlocuiește cu calea reală către fișierul depozit.xml
            Depozit depozit = new Depozit("connection_string"); // Înlocuiește cu connection string-ul real

            // Apelează metoda pentru a încărca datele din XML în depozit
            depozit.ImportDataFromXml(filePath);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchTerm = textBox1.Text.ToLower();

            XDocument doc = XDocument.Load("depozit.xml");
            var produse = doc.Descendants("produs")
                             .Where(p => p.Element("denumire").Value.ToLower().Contains(searchTerm));

            foreach (var produs in produse)
            {
                string denumire = produs.Element("denumire").Value;
                listBox1.Items.Add(denumire);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string selectedProduct = listBox1.SelectedItem as string;

            if (selectedProduct != null)
            {
                XDocument doc = XDocument.Load("depozit.xml");
                var produs = doc.Descendants("produs")
                                .FirstOrDefault(p => p.Element("denumire").Value == selectedProduct);

                if (produs != null)
                {
                    string cod = produs.Element("cod").Value;
                    string descriere = produs.Element("descriere").Value;
                    string pret = produs.Element("pret").Value;
                    string stoc = produs.Element("stoc").Value;

                    listBox2.Items.Add($"Cod: {cod}");
                    listBox2.Items.Add($"Descriere: {descriere}");
                    listBox2.Items.Add($"Pret: {pret}");
                    listBox2.Items.Add($"Stoc: {stoc}");

                    GenerateBarcode(cod, nextBarcodeId++);
                }
            }

        }

        private void GenerateBarcode(string code, int barcodeId)
        {
            int barcodeWidth = 200;
            int barcodeHeight = 100;

            
            Bitmap bitmap = new Bitmap(barcodeWidth, barcodeHeight);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                
                graphics.FillRectangle(Brushes.White, 0, 0, barcodeWidth, barcodeHeight);

                
                Font barcodeFont = new Font("Arial", 12);
                Brush barcodeBrush = Brushes.Black;

                
                SizeF textSize = graphics.MeasureString(code, barcodeFont);
                float x = (barcodeWidth - textSize.Width) / 2;
                float y = (barcodeHeight - textSize.Height) / 2;
                graphics.DrawString(code, barcodeFont, barcodeBrush, x, y);

                
                Pen barcodePen = new Pen(barcodeBrush, 2);
                graphics.DrawLine(barcodePen, x, y + textSize.Height + 5, x + textSize.Width, y + textSize.Height + 5);

                
                Font idFont = new Font("Arial", 10);
                SizeF idTextSize = graphics.MeasureString($"ID: {barcodeId}", idFont);
                float idX = (barcodeWidth - idTextSize.Width) / 2;
                float idY = y + textSize.Height + 10; 
                graphics.DrawString($"ID: {barcodeId}", idFont, barcodeBrush, idX, idY);
            }

           
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nume: Pascal\r\nPrenume: Otilia\r\nGrupa: M521", "Autor");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string selectedProduct = listBox1.SelectedItem as string;

            if (selectedProduct != null)
            {
                XDocument doc = XDocument.Load("depozit.xml");
                var produs = doc.Descendants("produs")
                                .FirstOrDefault(p => p.Element("denumire").Value == selectedProduct);

                if (produs != null)
                {
                    string cod = produs.Element("cod").Value;

                    // Creare și afișare form extern pentru codul QR
                    ShowQRCodeForm(cod);
                }
            }
        }
            private void ShowQRCodeForm(string code)
            {
                // Creare și afișare form extern pentru codul QR
                FormQRCode formQRCode = new FormQRCode(code);
                formQRCode.Show();
            }

        }
    }



