using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V3
{
    class Artikl
    {
        public static List<Artikl> SviArtikli = new List<Artikl>();
        public string Naziv { get; set; }
        public double Cijena { get; set; }

        public Artikl(string naziv, double cijena)
        {
            Naziv = naziv;
            Cijena = cijena;
            SviArtikli.Add(this);
        }
        public override string ToString()
        {
            return this.Naziv+" - "+this.Cijena.ToString();
        }
    }
}
