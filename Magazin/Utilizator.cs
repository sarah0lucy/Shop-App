using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;


namespace Magazin
{
    public class Utilizator
    {
        String username;
        String email;
        String password1;
        String idClient;



        public Utilizator(String username, String email, String password1)
        {
            this.username = username;
            this.email = email;
            this.password1 = password1;
            this.idClient = GenereazaCodUnic();
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }


        public String Parola
        {
            get { return password1; }
            set { password1 = value; }
        }

        public String IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        private string GenereazaCodUnic()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8); // Cod unic de 8 caractere
        }
        public static bool operator <(Utilizator P1, Utilizator P2)
        {
            return String.Compare(P1.username, P2.username) < 0 || (String.Compare(P1.username, P2.username) == 0 && String.Compare(P1.email, P2.email) < 0);
        }

        public static bool operator >(Utilizator P1, Utilizator P2)
        {
            return String.Compare(P1.username, P2.username) > 0 || (String.Compare(P1.username, P2.username) == 0 && String.Compare(P1.email, P2.email) > 0);
        }

        public void Scrie(BinaryWriter bw)
        {
            bw.Write(username);
            bw.Write(email);
            bw.Write(password1);
            bw.Write(idClient);
        }
        public static Utilizator citeste(BinaryReader br)
        {
            return new Utilizator(br.ReadString(), br.ReadString(), br.ReadString())
            {
                IdClient = br.ReadString()
            };
        }



    }

    public class ListaUtilizatori
    {
        private List<Utilizator> utilizatori;

        public ListaUtilizatori()
        {
            utilizatori = new List<Utilizator>();
        }

        public Utilizator daUtilizator(int pozitie)
        {
            try
            {
                return utilizatori[pozitie];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int NumarUtilizatori
        {
            get { return utilizatori.Count; }
        }

        public void AdaugaUtilizator(Utilizator utilizator)
        {
            for (int i = 0; i < utilizatori.Count; i++)
                if (utilizator < daUtilizator(i))
                {
                    utilizatori.Insert(i, utilizator);
                    return;
                }
            utilizatori.Add(utilizator);
        }

        public void Scrie(string cale)
        {
            using (StreamWriter sw = new StreamWriter(cale, true)) // Folosim true pentru a permite adăugarea la sfârșitul fișierului
            {
                foreach (var utilizator in utilizatori)
                {
                    sw.WriteLine($"{utilizator.Username},{utilizator.Email},{utilizator.Parola},{utilizator.IdClient}");
                }
            }
        }

        


        public Utilizator GasesteUtilizator(string username, string password)
        {
            foreach (var utilizator in utilizatori)
            {
                if (utilizator.Username == username && utilizator.Parola == password)
                {
                    return utilizator;
                }
            }
            return null; // Returnăm null dacă nu găsim utilizatorul cu username-ul și parola date
        }


        public void Citeste(string cale)
        {
            if (File.Exists(cale))
            {
                utilizatori.Clear(); // Curățăm lista pentru a evita încărcarea duplicatelor în memorie

                string[] lines = File.ReadAllLines(cale);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4)
                    {
                        Utilizator utilizator = new Utilizator(parts[0], parts[1], parts[2]);
                        utilizator.IdClient = parts[3];
                        utilizatori.Add(utilizator);
                    }
                }
            }
        }
    }
}
