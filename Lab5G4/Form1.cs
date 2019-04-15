using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5G4
{
    public partial class Form1 : Form
    {
        public List<Odjel> SviOdjeli= new List<Odjel>();
        public Prodaja prodaja = new Prodaja();
        public Marketing marketing = new Marketing();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnosZaposlenika_Click(object sender, EventArgs e)
        {
            if (TxtImeZaposlenici.Text.Length > 0)
            {
                Zaposlenik noviZaposlenik = new Zaposlenik(TxtImeZaposlenici.Text);
                if (CboxOdjeli.SelectedValue.ToString() == "Prodaja")
                    SviOdjeli[CboxOdjeli.SelectedIndex].DodajZaposlenika(noviZaposlenik);
                else
                    SviOdjeli[CboxOdjeli.SelectedIndex].DodajZaposlenika(noviZaposlenik);
            }
            LstZaposlenici.DataSource = null;
            LstZaposlenici.DataSource = SviOdjeli[CboxOdjeli.SelectedIndex].Zaposlenici;
        }

        private void LstZaposlenici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstZaposlenici.DataSource != null)
            {
                LblZaposlenik.Text = String.Format($"Ime i prezime zaposlenika:{LstZaposlenici.SelectedValue.ToString()}");
                LblOdjel.Text = String.Format($"Trenutni odjel:{((Zaposlenik)LstZaposlenici.SelectedValue).O.Naziv}");
            }
        }

        private void BtnPremjestiZaposlenika_Click(object sender, EventArgs e)
        {
            ((Zaposlenik)LstZaposlenici.SelectedValue).O.PremjestiZaposlenika((Zaposlenik)LstZaposlenici.SelectedValue,SviOdjeli[CboxOdjelPremjestaja.SelectedIndex]);
            LstZaposlenici.DataSource = null;
            LstZaposlenici.DataSource = SviOdjeli[CboxOdjeli.SelectedIndex].Zaposlenici;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SviOdjeli.Add(prodaja);
            SviOdjeli.Add(marketing);
            CboxOdjeli.DataSource = null;
            CboxOdjeli.DataSource = SviOdjeli;
        }

        private void CboxOdjeli_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstZaposlenici.DataSource = null;
            LstZaposlenici.DataSource = SviOdjeli[CboxOdjeli.SelectedIndex].Zaposlenici;
        }
    }
}
