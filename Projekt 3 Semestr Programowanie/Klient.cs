using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_Semestr_Programowanie
{
    internal class Klient
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Nr_telefonu { get; set; }
        public string Kraj { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public string nr_budynku { get; set; }

        public Klient(int ID, string Imie, string Nazwisko, string Nr_telefonu, string Kraj, string Miasto, string Ulica, string nr_budynku) 
        {
            this.ID = ID;
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Nr_telefonu = Nr_telefonu;
            this.Kraj = Kraj;
            this.Miasto = Miasto;
            this.Ulica = Ulica;
            this.nr_budynku = nr_budynku;

        }
    }
}
