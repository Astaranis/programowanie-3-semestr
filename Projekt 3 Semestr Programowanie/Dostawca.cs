using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_Semestr_Programowanie
{
    internal class Dostawca
    {
        public int ID_dostawcy { get; set; }
        public string nazwa_firmy { get; set; }
        public string Miasto { get; set; }
        public string ulica { get; set; }
        public string nr_budynku { get; set; }
        public string nr_telefonu { get; set; }

        public Dostawca(int ID_dostawcy, string nazwa_firmy, string Miasto, string ulica, string nr_budynku, string nr_telefonu)
        {
            this.ID_dostawcy = ID_dostawcy;
            this.nazwa_firmy = nazwa_firmy;
            this.Miasto = Miasto;
            this.ulica = ulica;
            this.nr_budynku = nr_budynku;
            this.nr_telefonu = nr_telefonu;

        }
    }
}