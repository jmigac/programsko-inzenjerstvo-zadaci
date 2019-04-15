using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V3
{
    class Racun
    {
        public static int BrojRacuna = 0;
        public int RedniBrojRacuna { get; set; }
        public int Kolicina { get; set; }
        public Artikl ArtiklRacuna;

        public Racun(int kolicina, Artikl artikl)
        {
            BrojRacuna++;
            RedniBrojRacuna = BrojRacuna;
            Kolicina = kolicina;
            ArtiklRacuna = artikl;
        }
        public override string ToString()
        {
            return RedniBrojRacuna.ToString()+" - "+ArtiklRacuna.Naziv+" - "+Kolicina.ToString()+" - "+ArtiklRacuna.Cijena*Kolicina;
        }
    }
}
