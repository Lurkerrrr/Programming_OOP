using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kolokwium_Zadanie_1
{
    public class Przedmiot
    {
        private string nazwa;
        private int ocena;

        public string Nazwa
        {
            get { return nazwa; }
            private set { nazwa = value; }
        }

        public int Ocena
        {
            get { return ocena; }
            private set { ocena = value; }
        }

        // Konstruktor
        public Przedmiot(string nazwa, int ocena)
        {
            this.nazwa = nazwa;
            this.ocena = ocena;
        }
    }
}
