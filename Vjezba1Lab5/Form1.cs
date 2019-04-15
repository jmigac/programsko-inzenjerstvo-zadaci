using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba1Lab5
{
    public partial class Form1 : Form
    {
        List<IPretraga> Knjiznica = new List<IPretraga>();
        public Form1()
        {
            InitializeComponent();
        }
        public void UnesiKnjigu(string naziv)
        {
            string nazivKnjige;
            int godina, izdanje;
            nazivKnjige = naziv.Split(';')[0];
            godina = int.Parse(naziv.Split(';')[1]);
            izdanje = int.Parse(naziv.Split(';')[2]);
            Knjiga novaKnjiga = new Knjiga(nazivKnjige, godina, izdanje);
            Knjiznica.Add(novaKnjiga);
            LstKnjiga.DataSource = null;
            LstKnjiga.DataSource = Knjiznica;
        }
        public void DodajAutora(Knjiga knjiga, Autor autor)
        {
            knjiga.Autori.Add(autor);
            LstAutora.DataSource = null;
            LstAutora.DataSource = knjiga.Autori;
        }
        public void UkloniAutora(Knjiga knjiga, Autor autor)
        {
            knjiga.UkloniAutora(autor);
        }
        public void Pretrazi(string keyword)
        {
            LstPretraga.Items.Clear();
            foreach (Knjiga knjiga in Knjiznica)
            {
                if (knjiga.Usporedi(keyword))
                {
                    LstPretraga.Items.Add(knjiga.ToString());
                    foreach (Autor autor in knjiga.Autori)
                    {
                        LstPretraga.Items.Add(autor.ToString());
                    }
                }
            }
            bool istina = false;
            foreach (Knjiga knjiga in Knjiznica)
            {
                istina = false;
                foreach (Autor autor in knjiga.Autori)
                {
                    if (autor.Usporedi(keyword))
                    {
                        if (!istina)
                        {
                            LstPretraga.Items.Add(knjiga.ToString());
                            istina = true;
                        }
                        LstPretraga.Items.Add(autor.ToString());
                    }
                }
            }
        }

        private void BtnDodajKnjigu_Click(object sender, EventArgs e)
        {
            UnesiKnjigu(TxtKnjiga.Text);
            TxtKnjiga.Clear();
        }

        private void BtnGenerateKnjige_Click(object sender, EventArgs e)
        {
            Knjiga novaKnjiga = new Knjiga("Knjiga1", 2015, 2);
            Knjiga novaKnjiga1 = new Knjiga("Knjiga2", 2012, 1);
            Knjiga novaKnjiga2 = new Knjiga("Knjiga3", 2011, 1);
            Knjiga novaKnjiga3 = new Knjiga("Knjiga4", 2010, 5);
            Knjiga novaKnjiga4 = new Knjiga("Knjiga5", 2017, 3);
            Knjiznica.Add(novaKnjiga);
            Knjiznica.Add(novaKnjiga1);
            Knjiznica.Add(novaKnjiga2);
            Knjiznica.Add(novaKnjiga3);
            Knjiznica.Add(novaKnjiga4);
            LstKnjiga.DataSource = null;
            LstKnjiga.DataSource = Knjiznica;
        }

        private void BtnDodajAutora_Click(object sender, EventArgs e)
        {
            Autor noviAutor = new Autor(TxtAutor.Text.Split(';')[0], TxtAutor.Text.Split(';')[1], TxtAutor.Text.Split(';')[2]);
            DodajAutora((Knjiga)Knjiznica[LstKnjiga.SelectedIndex], noviAutor);
            TxtAutor.Clear();
        }

        private void LstKnjiga_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstAutora.DataSource = null;
            LstAutora.DataSource = ((Knjiga)Knjiznica[LstKnjiga.SelectedIndex]).Autori;
        }

        private void BtnUkloniAutora_Click(object sender, EventArgs e)
        {
            UkloniAutora((Knjiga)Knjiznica[LstKnjiga.SelectedIndex],(Autor)LstAutora.SelectedItem);
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            Pretrazi(TxtUsporedba.Text);
        }
    }
}

