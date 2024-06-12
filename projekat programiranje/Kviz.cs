using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace projekat_programiranje
{
    public struct Pitanje
    {
        public string pitanje;
        public Dictionary<string, string> odgovori;
        public string tipPitanja;
        public string odgovor;
        public int brojPoena;

        public Pitanje(string pitanje, Dictionary<string, string> odgovori, string tipPitanja, string odgovor, int brojPoena)
        {
            this.pitanje = pitanje;
            this.odgovori = odgovori;
            this.tipPitanja = tipPitanja;
            this.odgovor = odgovor;
            this.brojPoena = brojPoena;
        }
    };

    public class KvizDeserializovan
    {
        [JsonProperty("ime")]
        public string Ime { get; set; }

        [JsonProperty("desk")]
        public string Desk { get; set; }

        [JsonProperty("pitanja")]
        public Dictionary<string, PitanjeDeserializovano> Pitanja { get; set; }
    }

    public class PitanjeDeserializovano
    {
        [JsonProperty("pitanje")]
        public string Pitanje { get; set; }

        [JsonProperty("odgovori")]
        public Dictionary<string, string> Odgovori { get; set; }

        [JsonProperty("tip_pitanja")]
        public string TipPitanja { get; set; }

        [JsonProperty("broj_poena")]
        public int BrojPoena { get; set; }

        [JsonProperty("vreme_dato")]
        public int VremeDato { get; set; }

        [JsonProperty("odgovor")]
        public string Odgovor { get; set; }
    }

    public class Kviz
    {
        public string ime;
        public string deskripcija;
        public Pitanje[] pitanja;

        public Kviz(string path)
        {
            string ime;
            string deskripcija;
            int iD;

            string text = File.ReadAllText(path);
            var objekat = JsonConvert.DeserializeObject<KvizDeserializovan>(text);

            ime = objekat.Ime;
            deskripcija = objekat.Desk;
            Pitanje[] pitanja = new Pitanje[objekat.Pitanja.Count];

            int counterI = 0;
            foreach (string key in objekat.Pitanja.Keys)
            {
                PitanjeDeserializovano ptnj = objekat.Pitanja[key];
                pitanja[counterI] = new Pitanje(ptnj.Pitanje, ptnj.Odgovori, ptnj.TipPitanja, ptnj.Odgovor, ptnj.BrojPoena);
                counterI++;
            }

            this.ime = ime;
            this.deskripcija = deskripcija;
            this.pitanja = pitanja;
        }

        public static Kviz[] UcitajKvizove()
        {
            string[] files = Directory.GetFiles("./kvizovi");

            Kviz[] ret = new Kviz[files.Length];
            
            for(int i = 0; i < files.Length; i++)
            {
                ret[i] = new Kviz(files[i]);
            }

            return ret;
        }
    }
}