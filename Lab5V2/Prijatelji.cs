using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5V2
{
    public class Prijatelji: Grupa
    {
        public Prijatelji(string naziv)
        {
            Naziv = naziv;
        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
