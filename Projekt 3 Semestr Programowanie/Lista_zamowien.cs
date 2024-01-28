using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_3_Semestr_Programowanie
{
    public partial class Lista_zamowien : Form
    {
        private Okno_Logowania o;
        private List<Zamowienie> Zamowienia;
        private List<Produkt> produkt;
        private int ID;
        private int click = 0;
        public Lista_zamowien(Okno_Logowania o, int id)
        {
            InitializeComponent();
            Zamowienia = new List<Zamowienie>();
            produkt = Baza_danych.pobierz_produkty();
            this.o = o;
            ID = id;
            pobierz_zamowienia();
            WyswietlZamowienia();

            Zamowienia_listbox.SelectedIndexChanged += Zamowienia_listbox_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Katalog kat = new Katalog();
            kat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                List<Zamowienie> z = Baza_danych.pobierz_zamowienia();
                int maxID = 0;
                foreach (Zamowienie zam in z)
                {
                    if (zam.ID_zamowienia > maxID)
                    {
                        maxID = zam.ID_zamowienia;
                    }
                }
                Zamowienia_listbox.Items.Add("Zamowienie " + maxID);
                click = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            o.WindowState = FormWindowState.Normal;
        }
        private void pobierz_zamowienia()
        {
            List<Zamowienie> z = Baza_danych.pobierz_zamowienia();
            foreach (Zamowienie zamowienie in z)
            {
                if (zamowienie.ID_klienta == ID)
                {
                    Zamowienia.Add(zamowienie);
                }
            }
        }
        private void WyswietlZamowienia()
        {
            foreach (Zamowienie z in Zamowienia)
            {
                if (!Zamowienia_listbox.Items.Contains(z.ID_zamowienia))
                    Zamowienia_listbox.Items.Add("Zamowienie " + z.ID_zamowienia);
            }
        }

        private void Zamowienia_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

                int index = Zamowienia_listbox.SelectedIndex;
                if (index != ListBox.NoMatches)
                {
                    Produkty_listbox.Items.Clear();
                    Zamowienie wybrane = Zamowienia[index];
                    int id = wybrane.ID_zamowienia;
                    MessageBox.Show(id.ToString());
                DodawanieProduktow(id);

                }
        }
        private void DodawanieProduktow(int idZam)
        {
            foreach(Zamowienie z in Zamowienia)
            {
                if(z.ID_zamowienia == idZam)
                {
                    int id = z.ID_produktu;
                    foreach(Produkt p in produkt)
                    {
                        if(id == p.ID_Produktu)
                        {
                            Produkty_listbox.Items.Add(p.Nazwa_Produktu);
                        }
                    }
                }
            }
        }

    }
}
