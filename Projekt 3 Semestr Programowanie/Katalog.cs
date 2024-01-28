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
    public partial class Katalog : Form
    {
        public Katalog()
        {
            InitializeComponent();
            dodaj_produkty();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Produkt> z = Baza_danych.pobierz_produkty();
            int index = listBox1.SelectedIndex;
            foreach (Produkt produkt in z)
            {
                if (produkt.ID_Produktu == index + 1)
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Produkt> z = Baza_danych.pobierz_produkty();
            int maxID = 0;
            foreach (Produkt pro in z)
            {
                if (pro.ID_Produktu > maxID)
                {
                    maxID = pro.ID_Produktu;
                }
            }
            maxID += 1;
            string nazwa = Nazwa_text.Text;
            string cena = Cena_text.Text;
            Baza_danych.dodawanie_produktu(maxID, nazwa, cena);
            dodaj_produkty();

        }
        private void dodaj_produkty()
        {
            List<Produkt> z = Baza_danych.pobierz_produkty();
            foreach (Produkt pro in z)
            {
                if (!listBox1.Items.Contains(pro.Nazwa_Produktu))
                {
                    listBox1.Items.Add(pro.Nazwa_Produktu);
                }
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            List<Produkt> produkty = Baza_danych.pobierz_produkty();
            int p = listBox1.SelectedIndex + 1;
            if (p != ListBox.NoMatches)
            {
                foreach (Produkt pro in produkty)
                {
                    if (pro.ID_Produktu == p)
                    {
                        Baza_danych.usuwanie_produktu(p); break;
                    }
                }
            }
            dodaj_produkty();
        }

        private void Zmien_Click(object sender, EventArgs e)
        {
            string nowa = nowa_cena.Text;
            int id = listBox1.SelectedIndex + 1;
            Baza_danych.aktualizacja_ceny(id, nowa);
            dodaj_produkty();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Produkt> p = Baza_danych.pobierz_produkty();
            int id = listBox1.SelectedIndex + 1;
            foreach (Produkt pro in p)
            {
                if(pro.ID_Produktu == id)
                {
                    nowa_cena.Text = pro.Cena;
                }
            }
        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Lista_zamowien la = new Lista_zamowien();
        //    la.Show();
        //    Close();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Lista_zamowien la = new Lista_zamowien();
        //    la.Show();
        //    Close();
        //}
    }
}
