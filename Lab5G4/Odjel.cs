using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G4
{
    /// <summary>
    /// Apstraktna klasa Odjel sadrži sve što bilo koji konkretni odjel treba 
    /// imati.
    /// </summary>
    public abstract class Odjel
    {
        /// <summary>
        /// Naziv pojedinog konkretnog odjela - može služiti ispisu.
        /// </summary>
        public string Naziv;

        /// <summary>
        /// Lista zaposlenika u odjelu.
        /// </summary>
        public List<Zaposlenik> Zaposlenici = new List<Zaposlenik>();


        /// <summary>
        /// Dodaje zaposlenika u listu zaposlenika i "osvještava" zaposlenika
        /// o tome kojem je odjelu pridružen.
        /// </summary>
        /// <param name="zaposlenik">Zaposlenik.</param>
        public void DodajZaposlenika(Zaposlenik zaposlenik)
        {
            if (zaposlenik.O != null)//Ako zaposlenik već pripada odjelu
                return;             //vrati se i ništa ne poduzimaj
            Zaposlenici.Add(zaposlenik);//Ako zaposlenik nema odjel dodaj u list
            zaposlenik.O = this; //Reci zaposleniku da je sad u ovom odjelu
        }

        /// <summary>
        /// Premješta zaposlenika u ciljni odjel. Provjerava ima li ovaj odjel
        /// tog zaposlenika, nakon čega mu briše dodijeljeni odjel i miče ga iz 
        /// liste zaposlenika. 
        /// Na kraju, poziva metodu DodajZaposlenika
        /// </summary>
        /// <param name="zap">Zaposlenik kojeg treba maknuti</param>
        /// <param name="ciljni">Ciljni odjel u koji se premješta zaposlenik</param>
        public void PremjestiZaposlenika(Zaposlenik zap, Odjel ciljni)
        {
            if (Zaposlenici.Contains(zap))
            {
                if (zap.O == this)
                    zap.O = null;
                Zaposlenici.Remove(zap);
                ciljni.DodajZaposlenika(zap);
            }
        }

        /// <summary>
        /// Predaje izvješće
        /// </summary>
        /// <returns>The izvjece.</returns>
        public virtual string PredajIzvjece()
        {
            return "";
        }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
