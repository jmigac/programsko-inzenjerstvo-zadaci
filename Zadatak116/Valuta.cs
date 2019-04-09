using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak116
{
    class Valuta
    {
        public static List<Valuta> SvePretvorbe = new List<Valuta>();
        public double ProdajniTecaj { get; set; }
        public double KupoprodajniTecaj { get; set; }
        public string NazivValute { get; set; }

        public Valuta(double prodajni, double kupoprodajni, string naziv)
        {
            ProdajniTecaj = prodajni;
            KupoprodajniTecaj = kupoprodajni;
            NazivValute = naziv;
            SvePretvorbe.Add(this);
        }
        public static Valuta VratiValutu(string naziv)
        {
            Valuta valutaZaVratiti = null;
            foreach (var valuta in SvePretvorbe)
            {
                if (valuta.NazivValute.ToLower().Equals(naziv.ToLower()))
                    valutaZaVratiti = valuta;
            }
            return valutaZaVratiti;
        }
    }
}
