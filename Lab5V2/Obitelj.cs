using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V2
{
    public class Obitelj: Grupa
    {
        public Obitelj(string naziv)
        {
            Naziv = naziv;
        }
        public override string ToString()
        {
            return this.Naziv;
        }

    }
}
