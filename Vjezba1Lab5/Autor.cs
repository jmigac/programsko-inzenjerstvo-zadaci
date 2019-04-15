using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1Lab5
{
    public class Autor: IPretraga
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        private string Email { get; set; }

        public Autor(string name, string lastName, string email)
        {
            Ime = name;
            Prezime = lastName;
            Email = email;
        }
        public bool Usporedi(string kljucnaRijec)
        {
            string imePrezime = Ime + " " + Prezime;
            if (imePrezime.ToLower().Contains(kljucnaRijec.ToLower()))
                return true;
            return false;
        }
        public string Ispisi()
        {
            return this.Ime + " " + this.Prezime + " " + this.Email;
        }
        public override string ToString()
        {
            return this.Ime+"-"+this.Prezime+"-"+this.Email;
        }
    }
}
