using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak132
{
    class PretvorbuValuta
    {
        public static List<PretvorbuValuta> SvePretvorbe = new List<PretvorbuValuta>();
        public static double Tecaj { get; set; }
        public double Valuta { get; set; }
        public double PretvorenaValuta;

        public PretvorbuValuta(double vrijednost1)
        {
            Valuta = vrijednost1;
            PretvorenaValuta = Valuta * Tecaj;
            SvePretvorbe.Add(this);
        }
        public static List<PretvorbuValuta> VratiPovijestPretvorbi()
        {
            List<PretvorbuValuta> novePretvorbe = SvePretvorbe;
            foreach (var pretvorba in novePretvorbe)
            {
                pretvorba.PretvorenaValuta = pretvorba.Valuta * Tecaj;
            }
            return novePretvorbe;
        }
    }
}
