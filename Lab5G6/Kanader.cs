using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G6
{
    public class Kanader: ILetjelica
    {
        public String Naziv { get; set; }
        public string Rezultat { get; set; }
        public Kanader(string naziv)
        {
            Naziv = naziv;
        }
        public bool Samodijagnostika()
        {
            int broj;
            Random randomBroj = new Random();
            broj = randomBroj.Next(1, 1000);
            if (broj % 6 == 0 || broj % 6 == 1)
            {
                return false;
            }
            return true;
        }

    }
}
