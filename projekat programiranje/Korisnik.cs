﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using static System.Windows.Forms.LinkLabel;

namespace projekat_programiranje
{
    public static class Korisnik
    {
        // Suma svih poena akumulirana kroz svaki kviz predjen
        public static int totalPoeni = 0;
        // Prosecna tacnost izrazena u decimali (70% = 0.7 itd.)
        public static double prosecnaTacnost = 0.0;

        public static int brojProdjenihKvizova = 0;
        public static int brojEjsovanihKvizova = 0; // Ejsovani kviz je kviz kojeg je korisnik uradio bez greške
        public static double razlomakEjsovanihProdjenih = 0.0; // broj ejsovanih / broj prodjenih
        public static Dictionary<string, int> uradjeniKvizovi = new Dictionary<string, int>();

        public struct KorisnikDeserializovan
        {
            [JsonProperty("_totalPoeni")]
            public int totalPoeni { get; set; }

            [JsonProperty("_prosecnaTacnost")]
            public double prosecnaTacnost { get; set; }

            [JsonProperty("_brojProdjenihKvizova")]
            public int brojProdjenihKvizova { get; set; }

            [JsonProperty("_brojEjsovanihKvizova")]
            public int brojEjsovanihKvizova { get; set; }

            [JsonProperty("_razlomakEjsovanihProdjenih")]
            public double razlomakEjsovanihProdjenih { get; set; }

            [JsonProperty("_uradjeniKvizovi")]
            public Dictionary<string, int> uradjeniKvizovi { get; set; }
        };

        public static void UcitajKorisnika()
        {
            string text = File.ReadAllText("./korisnik.json");
            var objekat = JsonConvert.DeserializeObject<KorisnikDeserializovan>(text);

            totalPoeni = objekat.totalPoeni;
            prosecnaTacnost = objekat.prosecnaTacnost;
            brojProdjenihKvizova = objekat.brojProdjenihKvizova;
            brojEjsovanihKvizova = objekat.brojEjsovanihKvizova;
            razlomakEjsovanihProdjenih = objekat.razlomakEjsovanihProdjenih;
            uradjeniKvizovi = objekat.uradjeniKvizovi;
        }
        struct data
        {
            public int _totalPoeni;
            public double _prosecnaTacnost;
            public int _brojProdjenihKvizova;
            public int _brojEjsovanihKvizova;
            public double _razlomakEjsovanihProdjenih;
            public Dictionary<string, int> _uradjeniKvizovi;
        };

        public static void SacuvajKorisnika()
        {

            data dataToSave = new data()
            {
                _totalPoeni = totalPoeni,
                _prosecnaTacnost = prosecnaTacnost,
                _brojProdjenihKvizova = brojProdjenihKvizova,
                _brojEjsovanihKvizova = brojEjsovanihKvizova,
                _razlomakEjsovanihProdjenih = razlomakEjsovanihProdjenih,
                _uradjeniKvizovi = uradjeniKvizovi
            };

            string stringjson = JsonConvert.SerializeObject(dataToSave);
            using (StreamWriter outputFile = new StreamWriter("./korisnik.json"))
            {
                outputFile.WriteLine(stringjson);
            }
        }
    }
}
