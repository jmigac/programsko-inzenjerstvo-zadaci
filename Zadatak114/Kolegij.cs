using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak114
{
    class Kolegij
    {
        public static List<Kolegij> SviKolegiji = new List<Kolegij>();
        public List<int> OcjeneKolegija = new List<int>();
        public string NazivKolegija { get; set; }
        public int SumaOcjena { get; set; }
        public Kolegij(string naziv)
        {
            NazivKolegija = naziv;
            SumaOcjena = 0;
            SviKolegiji.Add(this);
        }
        public static Kolegij VratiKolegij(string naziv)
        {
            Kolegij kolegijZaVratiti = null;
            foreach (var kolegij in SviKolegiji)
            {
                if (kolegij.NazivKolegija.ToLower().Equals(naziv.ToLower()))
                    kolegijZaVratiti = kolegij;
            }
            return kolegijZaVratiti;
        }
        public static Kolegij NadiNajlosijiKolegij()
        {
            Kolegij kolegijZaVratiti = null;
            List<Kolegij> SortiraniKolegiji = SviKolegiji.OrderBy(item => item.SumaOcjena).ToList();
            kolegijZaVratiti = SortiraniKolegiji[0];
            return kolegijZaVratiti;
        }
        public static Kolegij NadiNajboljiKolegij()
        {
            Kolegij kolegijZaVratiti = null;
            List<Kolegij> SortiraniKolegiji = SviKolegiji.OrderBy(item => item.SumaOcjena).ToList();
            kolegijZaVratiti = SortiraniKolegiji[SviKolegiji.Count - 1];
            return kolegijZaVratiti;
        }
        public static void IspisStanja()
        {
            string stanje = "";
            foreach (var kolegij in SviKolegiji)
            {
                stanje += String.Format($"{kolegij.NazivKolegija} - {kolegij.SumaOcjena}") + Environment.NewLine;
            }
            System.Windows.Forms.MessageBox.Show(stanje);
        }
    }
}
