using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazin
{
    class Produs
    {
        String cod;
        String denumire;
        String descriere;
        double pret;
        int stoc;
        public Produs(String cod, String denumire, String descriere, double pret, int stoc)
        {
            this.cod = cod;
            this.denumire = denumire;
            this.descriere = descriere;
            this.pret = pret;
            this.stoc = stoc;
        }

        public String Cod
        {
            get
            {
                return cod;
            }
            set
            {
                this.cod = value;
            }
        }
        public String Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                this.denumire = value;
            }
        }
        public String Descriere
        {
            get
            {
                return descriere;
            }
            set
            {
                this.descriere = value;
            }
        }
        public double Pret
        {
            get
            {
                return pret;
            }
            set
            {
                this.pret = value;
            }
        }
        public int Stoc
        {
            get
            {
                return stoc;
            }
            set
            {
                this.stoc = value;
            }
        }
        public static bool operator <=(Produs P1, Produs P2)
        {
            return String.Compare(P1.denumire, P2.denumire) <= 0;
        }
        public static bool operator >=(Produs P1, Produs P2)
        {
            return String.Compare(P1.denumire, P2.denumire) >= 0;
        }
    }
}
