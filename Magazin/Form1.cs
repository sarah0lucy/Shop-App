using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace Magazin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            ListaUtilizatori listaUtilizatori = new ListaUtilizatori();
            listaUtilizatori.Citeste("utilizatori.txt");

            Utilizator utilizator = listaUtilizatori.GasesteUtilizator(username, password);

            if (utilizator != null)
            {
                MessageBox.Show("Login cu succes!");
                Home mainForm = new Home(utilizator);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username-ul sau parola sunt incorecte.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
