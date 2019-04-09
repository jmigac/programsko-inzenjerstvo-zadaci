using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnosKnjige_Click(object sender, EventArgs e)
        {
            if (TxtNazivKnjige.Text.Length > 0)
            {
                Knjige novaKnjiga = new Knjige(TxtNazivKnjige.Text);
            }
        }

        private void BtnIzmjeniStatus_Click(object sender, EventArgs e)
        {
            if (TxtNaziv.Text.Length > 0)
            {
                int statusNoveKnjige = Knjige.VratiKnjigu(TxtNaziv.Text);
                if (statusNoveKnjige != 0)
                {
                    if (RadioIznajmi.Checked && !Knjige.SveKnjige[statusNoveKnjige].StatusKnjige && !RadioSlobodna.Checked)
                        Knjige.SveKnjige[statusNoveKnjige].StatusKnjige = true;
                    if (!RadioIznajmi.Checked && Knjige.SveKnjige[statusNoveKnjige].StatusKnjige && RadioSlobodna.Checked)
                        Knjige.SveKnjige[statusNoveKnjige].StatusKnjige = false;
                }
                else
                {
                    MessageBox.Show("Ne postoji navedena knjiga!");
                }
            }
        }

        private void VremenskoAžuriranjeLista_Tick(object sender, EventArgs e)
        {
            ListaSvihKnjiga.Items.Clear();
            ListaIznajmljenihKnjiga.Items.Clear();
            ListaSlobodnihKnjiga.Items.Clear();
            foreach (var knjiga in Knjige.SveKnjige)
            {
                if(knjiga.StatusKnjige)
                    ListaSvihKnjiga.Items.Add(String.Format($"{knjiga.NazivKnjige} - Iznajmljena"));
                else
                    ListaSvihKnjiga.Items.Add(String.Format($"{knjiga.NazivKnjige} - Slobodna"));
            }
            foreach (var knjiga in Knjige.SveKnjige)
            {
                if(knjiga.StatusKnjige)
                    ListaIznajmljenihKnjiga.Items.Add(String.Format($"{knjiga.NazivKnjige}"));
            }
            foreach (var knjiga in Knjige.SveKnjige)
            {
                if (!knjiga.StatusKnjige)
                    ListaSlobodnihKnjiga.Items.Add(String.Format($"{knjiga.NazivKnjige}"));
            }
        }
    }
}
