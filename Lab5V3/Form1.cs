using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDodajTrgovinu_Click(object sender, EventArgs e)
        {
            if (TxtNazivTrgovine.Text.Length > 0 && TxtAdresaTrgovine.Text.Length>0)
            {
                Trgovina novaTrgovina = new Trgovina(TxtNazivTrgovine.Text, TxtAdresaTrgovine.Text);
            }
            LstTrgovine.DataSource = null;
            LstTrgovine.DataSource = Trgovina.SveTrgovine;
        }

        private void BtnUnesiArtikl_Click(object sender, EventArgs e)
        {
            if(TxtNazivArtikla.Text.Length>0 && TxtCijenaArtikla.Text.Length > 0)
            {
                Artikl noviArtikl = new Artikl(TxtNazivArtikla.Text, double.Parse(TxtCijenaArtikla.Text));
            }
            LstArtikli.DataSource = null;
            LstArtikli.DataSource = Artikl.SviArtikli;
        }

        private void BtnUnesiRacun_Click(object sender, EventArgs e)
        {
            if (TxtKolicinaArtikla.Text.Length > 0)
            {
                Racun noviRacun = new Racun(int.Parse(TxtKolicinaArtikla.Text), (Artikl)LstArtikli.SelectedItem);
                Trgovina.SveTrgovine[LstTrgovine.SelectedIndex].DodajRacun(noviRacun);
            }
            LstArtiklaTrgovine.DataSource = null;
            LstArtiklaTrgovine.DataSource = Trgovina.SveTrgovine[LstTrgovine.SelectedIndex].SviRacuni;
            
        }

        private void LstArtikli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LstArtikli.DataSource!=null)
                LblOdabranArtikl.Text = String.Format($"Odabran artikl:{LstArtikli.SelectedItem.ToString()}");
        }

        private void LstTrgovine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstTrgovine.DataSource != null)
            {
                LblOdabranaTrgovina.Text = String.Format($"Odabrana trgovina:{LstTrgovine.SelectedItem.ToString()}");
                LstArtiklaTrgovine.DataSource = null;
                LstArtiklaTrgovine.DataSource = Trgovina.SveTrgovine[LstTrgovine.SelectedIndex].SviRacuni;
            }
                
        }
    }
}
