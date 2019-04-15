using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G4
{
    public class Zaposlenik
    {
        public string ImeIPrezime;
        /// <summary>
        /// Pamti u kojem je odjelu zapolenik. Drži referencu na odjel.
        /// </summary>
        public Odjel O;

        public Zaposlenik(string imeIPrezime)
        {
            this.ImeIPrezime = imeIPrezime;
        }
        public override string ToString()
        {
            return ImeIPrezime+" - "+O.Naziv;
        }
    }
}
