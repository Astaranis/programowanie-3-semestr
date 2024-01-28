using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_3_Semestr_Programowanie
{
    internal class Zamowienie
    {
        public int ID_zamowienia { get; set; }
        public int ID_klienta { get; set; }
        public string data_zamowienia { get; set; }
        public int ID_produktu { get; set; }
        public string ilosc { get; set; }

        public Zamowienie(int ID_zamowienia, int ID_klienta, string data_zamowienia, int ID_produktu, string ilosc)
        {
            this.ID_zamowienia = ID_zamowienia;
            this.ID_klienta = ID_klienta;
            this.data_zamowienia = data_zamowienia;
            this.ID_produktu = ID_produktu;
            this.ilosc = ilosc;

        }
    }
}
