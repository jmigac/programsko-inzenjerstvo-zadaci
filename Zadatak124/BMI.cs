using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak124
{
    class BMI
    {
        public static double VisokBMI { get; set; }
        public static double SrednjiBMI { get; set; }
        public static double NiskiBMI { get; set; }
        public static double Visina { get; set; }
        public static double Masa { get; set; }

       public static double IzracunavanjeBodyMassIndexa(string visina, string masa)
        {
            Visina = double.Parse(visina);
            Masa = double.Parse(masa);
            return Visina / Masa;
        }
    }
}
