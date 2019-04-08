using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04G03
{
    class Govedo
    {
        public static List<Govedo> SvaGoveda = new List<Govedo>();
        public string NazivGoveda { get; set; }
        public string SpolGoveda { get; set; }
        public string BojaGoveda { get; set; }

        public Govedo(string naziv, string spol, string boja)
        {
            NazivGoveda = naziv;
            SpolGoveda = spol;
            BojaGoveda = boja;
            SvaGoveda.Add(this);
        }
        public static void IspisivanjeSvihGoveda()
        {
            string ispis = "";
            foreach (var govedo in SvaGoveda)
            {
                ispis += govedo.NazivGoveda + " " + govedo.SpolGoveda + " " + govedo.BojaGoveda + Environment.NewLine;
            }
            System.Windows.Forms.MessageBox.Show(ispis);
        }
        
    }
}
