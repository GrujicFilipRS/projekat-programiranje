using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projekat_programiranje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KvizoviLista.View = View.List;
            foreach (Kviz kv in Program.kvizovi)
            {
                KvizoviLista.Items.Add(new ListViewItem(kv.ime));
            }

            IgranjeKvizova.pokreniBTN = pokreniBTN;
            IgranjeKvizova.lista = KvizoviLista;
            IgranjeKvizova.kvizoviTXT = kvizoviText;
            IgranjeKvizova.deskTXT = deskripcijaText;
            IgranjeKvizova.imeTXB = imeKvizaText;
            IgranjeKvizova.deskTXB = deskripcijaKvizaText;
            IgranjeKvizova.pitanjeText = pitanjeKvizText;
            IgranjeKvizova.poeniTXT = poeniTXT;
            IgranjeKvizova.odg1 = odgovor1;
            IgranjeKvizova.odg2 = odgovor2;
            IgranjeKvizova.odg3 = odgovor3;
            IgranjeKvizova.odg4 = odgovor4;
            IgranjeKvizova.ukupnoPoena = ukupnoPoena;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void KvizoviLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KvizoviLista.SelectedItems.Count > 0)
            {
                foreach (Kviz kv in Program.kvizovi)
                {
                    if (kv.ime == KvizoviLista.SelectedItems[0].Text)
                    {
                        Program.kvizSelektovan = kv;
                        break;
                    }
                }
            }
            else
            {
                Program.kvizSelektovan = null;
            }

            if(Program.kvizSelektovan != null)
            {
                imeKvizaText.Text = Program.kvizSelektovan.ime;
                deskripcijaKvizaText.Text = Program.kvizSelektovan.deskripcija;
            }

            pokreniBTN.Enabled = Program.kvizSelektovan != null;
        }

        private void pokreniBTN_Click(object sender, EventArgs e)
        {
            IgranjeKvizova.KreniKviz();
        }

        private void odgovor1_Click(object sender, EventArgs e)
        {
            if (IgranjeKvizova.trenutniKviz.kviz.pitanja[IgranjeKvizova.trenutniKviz.trenutnoPitanje].tipPitanja == "kviz")
                IgranjeKvizova.Pogodi(IgranjeKvizova.trenutniKviz.kviz.pitanja.ElementAt(IgranjeKvizova.trenutniKviz.trenutnoPitanje).odgovori.ElementAt(0).Key);
            else
                IgranjeKvizova.Pogodi("t");
        }

        private void odgovor2_Click(object sender, EventArgs e)
        {
            if (IgranjeKvizova.trenutniKviz.kviz.pitanja[IgranjeKvizova.trenutniKviz.trenutnoPitanje].tipPitanja == "kviz")
                IgranjeKvizova.Pogodi(IgranjeKvizova.trenutniKviz.kviz.pitanja.ElementAt(IgranjeKvizova.trenutniKviz.trenutnoPitanje).odgovori.ElementAt(1).Key);
            else
                IgranjeKvizova.Pogodi("f");
        }

        private void odgovor3_Click(object sender, EventArgs e)
        {
            IgranjeKvizova.Pogodi(IgranjeKvizova.trenutniKviz.kviz.pitanja.ElementAt(IgranjeKvizova.trenutniKviz.trenutnoPitanje).odgovori.ElementAt(2).Key);
        }

        private void odgovor4_Click(object sender, EventArgs e)
        {
            IgranjeKvizova.Pogodi(IgranjeKvizova.trenutniKviz.kviz.pitanja.ElementAt(IgranjeKvizova.trenutniKviz.trenutnoPitanje).odgovori.ElementAt(3).Key);
        }
    }
}
