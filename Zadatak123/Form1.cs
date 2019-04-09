using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak123
{
    public partial class Form1 : Form
    {
        public static int Minuta;
        public static int Sekunda;
        public static int MiliSekunda;
        public static bool AktivnoBrojanjeVremena;
        public static int PotrebnoVrijemeUcitavanja;
        public static List<Uri> PovijestWebStranica = new List<Uri>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if(TxtLink.Text.Length>0 && TxtLink.Text.Contains("http://www"))
            {
                Uri noviLink = new Uri(TxtLink.Text);
                WebBrowser.Url = noviLink;
                VrijemeUcitavanja.Enabled = true;
                AktivnoBrojanjeVremena = true;
            }
        }

        private void VrijemeUcitavanja_Tick(object sender, EventArgs e)
        {
            if (AktivnoBrojanjeVremena)
            {
                MiliSekunda++;
                if (MiliSekunda >= 100)
                {
                    Sekunda++;
                    MiliSekunda = 0;
                }
                if (Sekunda >= 59)
                {
                    Minuta++;
                    Sekunda = 0;
                }
            }
        }
        private void ResetirajVrijeme()
        {
            Minuta = 0;
            Sekunda = 0;
            MiliSekunda = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetirajVrijeme();
            AktivnoBrojanjeVremena = false;
            
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            AktivnoBrojanjeVremena = false;
            VrijemeUcitavanja.Enabled = false;
            PotrebnoVrijemeUcitavanja = MiliSekunda + (Sekunda * 1000) + (Minuta * 60 * 1000);
            string upisPovijest = "";
            upisPovijest += TxtLink.Text + " - " + PotrebnoVrijemeUcitavanja + "ms";
            if (WebBrowser.Url.ToString().Length > 0)
            {
                ListaPovijestPretrazivanja.Items.Add(upisPovijest);
                PovijestWebStranica.Add(WebBrowser.Url);
            }
            ResetirajVrijeme();
        }

        private void BtnNazad_Click(object sender, EventArgs e)
        {
            if (PovijestWebStranica.Count >= 2)
            {
                Uri trenutnaStranica = WebBrowser.Url;
                for (int i = 0; i < PovijestWebStranica.Count; i++)
                {
                    if (PovijestWebStranica[i].Equals(trenutnaStranica))
                        WebBrowser.Url = PovijestWebStranica[i - 1];
                }
            }

        }

        private void BtnOsvjezi_Click(object sender, EventArgs e)
        {
            Uri noviLink = new Uri(TxtLink.Text);
            WebBrowser.Url = noviLink;
        }
    }
}
