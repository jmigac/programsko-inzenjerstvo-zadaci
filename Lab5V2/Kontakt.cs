using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V2
{
    class Kontakt
    {
        public string Ime { get; set; }
        public string Broj { get; set; }
        List<Grupa> Grupe = new List<Grupa>();

        public Kontakt(string ime, string broj)
        {
            Ime = ime;
            Broj = broj;
        }
        public void DodajUGrupu(Grupa grupa)
        {
            Grupe.Add(grupa);
        }
        public bool JeLiUGrupi(Grupa grupa)
        {
            bool vrijednostZaVratiti = false;
            foreach (Grupa item in Grupe)
            {
                if (item.Equals(grupa))
                    vrijednostZaVratiti = true;
            }
            return vrijednostZaVratiti;
        }
        public override string ToString()
        {
            return this.Ime+" - "+this.Broj;
        }
    }
}
