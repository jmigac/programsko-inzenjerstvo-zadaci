using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G4
{
    public class Marketing : Odjel
    {
        private string Izvjesce = "Ovo je marketing";
        public Marketing()
        {
            Naziv = "Marketing";
        }

        public override string PredajIzvjece()
        {
            return Izvjesce;
        }
    }
}
