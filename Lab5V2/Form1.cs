using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5V2
{
    public partial class Form1 : Form
    {
        List<Kontakt> SviKontakti = new List<Kontakt>();
        List<Grupa> SveGrupe = new List<Grupa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDodajGrupu_Click(object sender, EventArgs e)
        {
            if (TxtNazivGrupe.Text.Length > 0)
            {
                switch (CboxVrsteGrupa.SelectedItem.ToString().ToLower())
                {
                    case "obitelj":
                        {
                            Obitelj novaObitelj = new Obitelj(TxtNazivGrupe.Text);
                            SveGrupe.Add(novaObitelj);
                            break;
                        }
                    case "prijatelji":
                        {
                            Prijatelji noviPrijatelji = new Prijatelji(TxtNazivGrupe.Text);
                            SveGrupe.Add(noviPrijatelji);
                            break;
                        }
                }
            }
            LstGrupe.DataSource = null;
            LstGrupe.DataSource = SveGrupe;
            CboxFilter.DataSource = null;
            CboxFilter.DataSource = SveGrupe;
        }

        private void BtnUnesiKontakt_Click(object sender, EventArgs e)
        {
            if(TxtIme.Text.Length>0 && TxtBroj.Text.Length > 0)
            {
                Kontakt noviKontakt = new Kontakt(TxtIme.Text,TxtBroj.Text);
                SviKontakti.Add(noviKontakt);
            }
            LstKontakti.DataSource = null;
            LstKontakti.DataSource = SviKontakti;
        }

        private void BtnDodjeli_Click(object sender, EventArgs e)
        {
            Kontakt kontaktZaDodjelu;
            Grupa grupaZaDodjelu;
            kontaktZaDodjelu = (Kontakt)LstKontakti.SelectedItem;
            grupaZaDodjelu = (Grupa)LstGrupe.SelectedItem;
            kontaktZaDodjelu.DodajUGrupu(grupaZaDodjelu);
        }

        private void CboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstSviKontaktiPoGrupama.Items.Clear();
            foreach (Kontakt kontakt in SviKontakti)
            {
                if (kontakt.JeLiUGrupi((Grupa)CboxFilter.SelectedItem))
                    LstSviKontaktiPoGrupama.Items.Add(kontakt);
            }
        }
    }
}
