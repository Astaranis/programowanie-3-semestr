using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_Semestr_Programowanie
{
    internal class Produkt
    {
        public int ID_Produktu { get; set; }
        public string Nazwa_Produktu { get; set; }
        public string Cena { get; set; }

        public Produkt(int ID_Produktu, string Nazwa_Produktu, string Cena)
        {
            this.ID_Produktu = ID_Produktu;
            this.Nazwa_Produktu = Nazwa_Produktu;
            this.Cena = Cena;

        }
    }
}
