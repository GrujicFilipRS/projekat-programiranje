using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace projekat_programiranje
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Korisnik.UcitajKorisnika();

            Kviz matematika1 = new Kviz("./kvizovi/matematika-1.json");
            Kviz istorija1 = new Kviz("./kvizovi/istorija-1.json");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
