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
    public partial class Okno_Logowania : Form
    {
        private List<Klient> Klienci;
        private Klient kl;
        public Okno_Logowania()
        {

            InitializeComponent();
            Klienci = Baza_danych.pobierz_klientow();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string login = Imie.Text;
            string haslo = Nazwisko.Text;
            bool czyLogin = false;
            bool czyHaslo = false;
            foreach (Klient k in Klienci)
            {
                if (k.Imie == login)
                {
                    czyLogin = true;
                    if (k.Nazwisko == haslo)
                    {
                        czyHaslo = true;
                        kl=k;
                    }
                }

            }
            if (czyLogin && czyHaslo)
            {

                MessageBox.Show(kl.ID.ToString());
                Lista_zamowien lz = new Lista_zamowien(this, kl.ID);
                lz.Show();
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                MessageBox.Show("Złe Dane !");
            }
        }



    }
}
