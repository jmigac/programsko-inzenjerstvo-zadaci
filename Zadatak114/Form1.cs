using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak114
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNazivKolegija.Text.Length > 0)
            {
                Kolegij noviKolegij = new Kolegij(TxtNazivKolegija.Text);
                TxtNazivKolegija.Text = "";
                TxtNazivKolegija.Focus();
            }
        }

        private void BtnUnosOcjene_Click(object sender, EventArgs e)
        {
            if(TxtUnosOcjeneNazivKolegija.Text.Length>0 && TxtUnosOcjene.Text.Length > 0)
            {
                Kolegij odabraniKolegij = Kolegij.VratiKolegij(TxtUnosOcjeneNazivKolegija.Text);
                if(odabraniKolegij != null)
                {
                    odabraniKolegij.OcjeneKolegija.Add(int.Parse(TxtUnosOcjene.Text));
                    odabraniKolegij.SumaOcjena += int.Parse(TxtUnosOcjene.Text);
                    Kolegij najbolji = Kolegij.NadiNajboljiKolegij();
                    Kolegij najlosiji = Kolegij.NadiNajlosijiKolegij();
                    if (najbolji != null && najlosiji != null)
                    {
                        LabelNajbolji.Text = String.Format($"Najbolji kolegij je: {najbolji.NazivKolegija}");
                        LabelNajlosiji.Text = String.Format($"Najlošiji kolegij je: {najlosiji.NazivKolegija}");
                    }
                }
                else
                {
                    MessageBox.Show("Kolegij ne postoji!");
                }
            }
        }

        private void LabelNajbolji_Click(object sender, EventArgs e)
        {
            Kolegij.IspisStanja();
        }
    }
}
