using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace projekat_programiranje
{
    public static class Korisnik
    {
        // Suma svih poena akumulirana kroz svaki kviz predjen
        public static int totalPoeni;
        // Prosecna tacnost izrazena u decimali (70% = 0.7 itd.)
        public static double prosecnaTacnost;

        public static int brojProdjenihKvizova;
        public static int brojEjsovanihKvizova; // Ejsovani kviz je kviz kojeg je korisnik uradio bez greške
        public static double razlomakEjsovanihProdjenih; // broj ejsovanih / broj prodjenih
        public static string[] uradjeniKvizovi = new string[9999];

        public static void UcitajKorisnika()
        {
            // TODO Gartman
        }
         
        public static void SacuvajKorisnika()
        {
            // TODO Grujić
        }
    }
}
