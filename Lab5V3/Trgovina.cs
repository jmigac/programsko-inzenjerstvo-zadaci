using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V3
{
    class Trgovina
    {
        public static List<Trgovina> SveTrgovine = new List<Trgovina>();
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public List<Racun> SviRacuni = new List<Racun>();

        public Trgovina(string naziv, string adresa)
        {
            Naziv = naziv;
            Adresa = adresa;
            SveTrgovine.Add(this);
        }
        public void DodajRacun(Racun racun)
        {
            SviRacuni.Add(racun);
        }
        public override string ToString()
        {
            return this.Naziv+" - "+this.Adresa;
        }
        public List<Racun> VratiSveRacune()
        {
            return SviRacuni;
        }
    }
}
