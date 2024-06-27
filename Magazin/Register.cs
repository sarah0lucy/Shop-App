using System.Text.RegularExpressions;

namespace Magazin
{
    public partial class Register : Form
    {

        private ListaUtilizatori utilizatori;

        public Register()
        {
            InitializeComponent();
            utilizatori = new ListaUtilizatori();
        }


        public bool ValidateUsername(string username)
        {
            // Verifica lungimea username-ului între 6 și 15 caractere
            if (username.Length < 6 || username.Length > 15)
            {
                return false;
            }

            // Verifica dacă username-ul conține doar litere, cifre și puncte
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9.]+$"))
            {
                return false;
            }

            return true;
        }

        public bool ValidateEmail(string email)
        {
            // Verifică dacă email-ul respectă formatul valid
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                return false;
            }

            return true;
        }

        public bool ValidatePasswords(string password1, string password2)
        {
            // Verifică dacă ambele parole sunt completate
            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                return false;
            }

            // Verifică dacă parolele sunt identice
            if (password1 != password2)
            {
                return false;
            }

            // Verifică dacă parola respectă cerințele (litere, cifre, majuscule, caractere speciale) si sa aiba cel putin 8 caractere
            if (!Regex.IsMatch(password1, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
            {
                return false;
            }

            return true;
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            string username = BoxUsername.Text;
            string email = BoxEmail.Text;
            string password1 = BoxParola.Text;
            string password2 = BoxParola2.Text;

            // Verificarea fiecărui câmp în parte
            if (!ValidateUsername(username))
            {
                MessageBox.Show("Username-ul trebuie să conțină între 6 și 15 caractere și să fie format din litere, cifre și puncte.");
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Adresa de email nu este validă.");
                return;
            }

            if (!ValidatePasswords(password1, password2))
            {
                MessageBox.Show("Parolele trebuie să fie identice, sa aiba cel putin 8 carecteresi si să conțină cel puțin o literă mică, o literă mare, o cifră și un caracter special.");
                return;
            }

            Utilizator utilizator = new Utilizator(username, email, password1);
            utilizatori.AdaugaUtilizator(utilizator);
            utilizatori.Scrie("utilizatori.txt");



            // Dacă toate validările sunt îndeplinite, executați acțiunile corespunzătoare
            // De exemplu, reîmprospătarea paginii sau navigarea la o altă pagină
            MessageBox.Show("Inregistrare cu succes!");
            Home mainForm = new Home(utilizator);
            mainForm.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }


}
