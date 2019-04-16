using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G6
{
    public interface ILetjelica
    {
        string Naziv { get; set; }
        bool Samodijagnostika();
    }
}
