using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba1Lab5
{
    public class Knjiga: IPretraga
    {
        public List<IPretraga> Autori = new List<IPretraga>();
        public string Naziv { get; set; }
        public int Godina { get; set; }
        public int Izdanje { get; set; }

        public Knjiga(string naziv, int godina, int izdanje)
        {
            Naziv = naziv;
            Godina = godina;
            Izdanje = izdanje;
        }
        public void DodajAutora(Autor autor)
        {
            Autori.Add(autor);
        }
        public void UkloniAutora(Autor autor)
        {
            Autor autorZaIzbrisati = null;
            foreach (Autor item in Autori)
            {
                if (item.Equals(autor))
                    autorZaIzbrisati=item;
            }
            if (autorZaIzbrisati != null)
                Autori.Remove(autorZaIzbrisati);
        }
        public bool Usporedi(string kljucnaRijec)
        {
            if (Naziv.ToLower().Contains(kljucnaRijec.ToLower()))
                return true;
            return false;
        }
        public string Ispisi()
        {
            return this.Naziv + " " + this.Godina.ToString() + " " + this.Izdanje.ToString();
        }
        public override string ToString()
        {
            return String.Format($"{this.Naziv} - {this.Godina} - {this.Izdanje}");
        }
    }
}
