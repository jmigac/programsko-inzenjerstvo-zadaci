using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak117
{
    class Knjige
    {
        public static List<Knjige> SveKnjige = new List<Knjige>();
        public string NazivKnjige { get; set; }
        public bool StatusKnjige { get; set; }

        public Knjige(string naziv)
        {
            NazivKnjige = naziv;
            StatusKnjige = false;
            SveKnjige.Add(this);
        }
        public static int VratiKnjigu(string nazivKnjige)
        {
            int vrijednostZaVratiti = 0;
            for (int i=0;i<SveKnjige.Count;i++)
            {
                if (SveKnjige[i].NazivKnjige.ToLower().Equals(nazivKnjige.ToLower()))
                {
                    vrijednostZaVratiti = i;
                }
            }
            return vrijednostZaVratiti;
        }
    }
}
