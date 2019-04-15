using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G4
{
    public class Prodaja : Odjel
    {
        private string Izvjesce = "Ovo je prodaja";

        public Prodaja()
        {
            this.Naziv = "Prodaja";
        }

        public override string PredajIzvjece()
        {
            return Izvjesce;
        }
    }
}
