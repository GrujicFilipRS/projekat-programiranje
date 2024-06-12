using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat_programiranje
{
    public class KvizInstanca
    {
        public int brojPoenaDobijeno = 0;
        public double tacnost = 0.0;
        public int trenutnoPitanje = 0;
        public Kviz kviz;

        public KvizInstanca(Kviz kv)
        {
            kviz = kv;
        }
    }

    public static class IgranjeKvizova
    {
        public static Button pokreniBTN; public static ListView lista; public static Label kvizoviTXT; public static Label deskTXT; public static TextBox imeTXB; public static TextBox deskTXB; public static Label pitanjeText; public static Label poeniTXT; public static Button odg1; public static Button odg2; public static Button odg3; public static Button odg4;
        public static Label ukupnoPoena;

        public static KvizInstanca trenutniKviz;

        public static void SetQuiz(Kviz kv)
        {
            trenutniKviz = new KvizInstanca(kv);
        }

        public static void KreniKviz()
        {
            SetQuiz(Program.kvizSelektovan);

            pokreniBTN.Enabled = false;
            lista.Enabled = false;
            kvizoviTXT.Enabled = false;
            deskTXT.Enabled = false;
            imeTXB.Enabled = false;
            deskTXB.Enabled = false;
            pokreniBTN.Visible = false;
            lista.Visible = false;
            kvizoviTXT.Visible = false;
            deskTXT.Visible = false;
            imeTXB.Visible = false;
            deskTXB.Visible = false;

            pitanjeText.Visible = true;
            pitanjeText.Enabled = true;
            poeniTXT.Visible = true;
            poeniTXT.Enabled = true;
            ukupnoPoena.Visible = true;
            ukupnoPoena.Enabled = true;

            pitanjeText.Text = Program.kvizSelektovan.pitanja[0].pitanje;
            poeniTXT.Text = "Poeni ovog pitanja: " + Program.kvizSelektovan.pitanja[0].brojPoena.ToString();
            ukupnoPoena.Text = "Ukupno poena: " + trenutniKviz.brojPoenaDobijeno;

            if (Program.kvizSelektovan.pitanja[0].tipPitanja == "kviz")
            {
                Dictionary<string, string> odgovori = Program.kvizSelektovan.pitanja[0].odgovori;


                odg1.Enabled = true;
                odg1.Visible = true;
                odg1.Text = odgovori.Keys.ElementAt(0);

                odg2.Enabled = true;
                odg2.Visible = true;
                odg2.Text = odgovori.Keys.ElementAt(1);

                odg3.Enabled = true;
                odg3.Visible = true;
                odg3.Text = odgovori.Keys.ElementAt(2);

                odg4.Enabled = true;
                odg4.Visible = true;
                odg4.Text = odgovori.Keys.ElementAt(3);

            }
            else
            {
                odg1.Enabled = true;
                odg1.Visible = true;
                odg2.Enabled = true;
                odg2.Visible = true;
            }
        }

        public static void Pogodi(string odgovor)
        {
            string tacanOdgovor = trenutniKviz.kviz.pitanja[trenutniKviz.trenutnoPitanje].odgovor;
            if (tacanOdgovor == null)
            {
                Dictionary<string, string> odgovori = trenutniKviz.kviz.pitanja[trenutniKviz.trenutnoPitanje].odgovori;
                foreach(string key in odgovori.Keys)
                {
                    if (odgovori[key] == "t")
                        tacanOdgovor = key;
                }
            }

            string tipPitanja = trenutniKviz.kviz.pitanja[trenutniKviz.trenutnoPitanje].tipPitanja;

            PredjiDalje(odgovor == tacanOdgovor);

        }

        public static void PredjiDalje(bool tacno)
        {
            if (tacno)
            {
                trenutniKviz.brojPoenaDobijeno += trenutniKviz.kviz.pitanja[trenutniKviz.trenutnoPitanje].brojPoena;
            }
            trenutniKviz.trenutnoPitanje++;


            if (trenutniKviz.trenutnoPitanje < trenutniKviz.kviz.pitanja.Length)
                PostaviPitanje();
            else
                PogledajPoene();
        }

        public static void PogledajPoene()
        {
            MessageBox.Show("Poena dobijeno: " + trenutniKviz.brojPoenaDobijeno.ToString());
            ZavrsiKviz();
        }

        public static void PostaviPitanje()
        {
            pitanjeText.Text = Program.kvizSelektovan.pitanja[trenutniKviz.trenutnoPitanje].pitanje;
            poeniTXT.Text = "Poeni ovog pitanja: " + Program.kvizSelektovan.pitanja[trenutniKviz.trenutnoPitanje].brojPoena.ToString();
            ukupnoPoena.Text = "Ukupno poena: " + trenutniKviz.brojPoenaDobijeno;

            if (Program.kvizSelektovan.pitanja[trenutniKviz.trenutnoPitanje].tipPitanja == "kviz")
            {
                Dictionary<string, string> odgovori = Program.kvizSelektovan.pitanja[trenutniKviz.trenutnoPitanje].odgovori;


                odg1.Enabled = true;
                odg1.Visible = true;
                odg1.Text = odgovori.Keys.ElementAt(0);

                odg2.Enabled = true;
                odg2.Visible = true;
                odg2.Text = odgovori.Keys.ElementAt(1);

                odg3.Enabled = true;
                odg3.Visible = true;
                odg3.Text = odgovori.Keys.ElementAt(2);

                odg4.Enabled = true;
                odg4.Visible = true;
                odg4.Text = odgovori.Keys.ElementAt(3);

            }
            else
            {
                odg1.Enabled = true;
                odg1.Visible = true;
                odg1.Text = "True";

                odg2.Enabled = true;
                odg2.Visible = true;
                odg2.Text = "False";

                odg3.Enabled = false;
                odg3.Visible = false;
                odg4.Enabled = false;
                odg4.Visible = false;
            }
        }

        public static void ZavrsiKviz()
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
