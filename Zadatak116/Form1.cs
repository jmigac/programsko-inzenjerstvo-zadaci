using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnosValute_Click(object sender, EventArgs e)
        {
            if(TxtNazivValute.Text.Length>0 && TxtProdajni.Text.Length > 0 && TxtKupoprodajni.Text.Length > 0)
            {
                Valuta novoValuta = new Valuta(double.Parse(TxtProdajni.Text), double.Parse(TxtKupoprodajni.Text), TxtNazivValute.Text);
                TxtNazivValute.Text = "";
                TxtProdajni.Text = "";
                TxtKupoprodajni.Text = "";
            }
        }

        private void TimerIspisUListe_Tick(object sender, EventArgs e)
        {
            ListaSvihValuta.Items.Clear();
            foreach (var valuta in Valuta.SvePretvorbe)
            {
                ListaSvihValuta.Items.Add(String.Format($"{valuta.NazivValute} - {valuta.KupoprodajniTecaj} - {valuta.ProdajniTecaj}"));
            }
        }

        private void BtnIzracunaj_Click(object sender, EventArgs e)
        {
            if(TxtNazivPretvorbe.Text.Length>0 && TxtVrijednostPretvorbe.Text.Length > 0)
            {
                double iznos;
                Valuta trazenaValuta = Valuta.VratiValutu(TxtNazivPretvorbe.Text);
                if (trazenaValuta != null)
                {
                    if(RadioKupoprodajni.Checked && !RadioProdajni.Checked)
                    {
                        iznos = double.Parse(TxtVrijednostPretvorbe.Text) / trazenaValuta.KupoprodajniTecaj;
                        ListaPretvorbi.Items.Add(String.Format($"HRK -> {trazenaValuta.NazivValute} - Kupoprodajna vrijednost:{iznos:0.00}{trazenaValuta.NazivValute}"));
                    }
                    if(!RadioKupoprodajni.Checked && RadioProdajni.Checked)
                    {
                        iznos = double.Parse(TxtVrijednostPretvorbe.Text) * trazenaValuta.ProdajniTecaj;
                        ListaPretvorbi.Items.Add(String.Format($"{trazenaValuta.NazivValute} -> HRK - Prodajna vrijednost:{iznos:0.00}HRK"));
                    }
                }
                else
                {
                    MessageBox.Show("Ne postoji tražena valuta!");
                }
            }
        }
    }
}
