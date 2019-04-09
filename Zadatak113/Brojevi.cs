using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak113
{
    class Brojevi
    {
        public static List<Brojevi> SviBrojevi = new List<Brojevi>();
        public int Broj { get; set; }
        public Brojevi(int broj)
        {
            Broj = broj;
            SviBrojevi.Add(this);
        }
        public static List<Brojevi> VratiSortiranuListu()
        {
            List<Brojevi> SortiranaLista = SviBrojevi.OrderBy(br => br.Broj).ToList();
            return SortiranaLista;
        }
    }
}
