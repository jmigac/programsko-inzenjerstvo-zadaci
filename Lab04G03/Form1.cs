using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04G03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDodajGovedo_Click(object sender, EventArgs e)
        {
            if (TxtNazivGoveda.Text.Length > 1)
            {
                Govedo novoGovedo = new Govedo(TxtNazivGoveda.Text, ComboSpol.SelectedItem.ToString(), ComboBoja.SelectedItem.ToString());
                TxtNazivGoveda.Text = "";
                TxtNazivGoveda.Focus();
            }
        }
        private void ResetirajListu()
        {
            ListaIspisaGoveda.Items.Clear();
        }
        private void BtnSortBoja_Click(object sender, EventArgs e)
        {
            ResetirajListu();
            string unosGoveda = "";
            List<Govedo> sortiranaGovedaPoBoji = Govedo.SvaGoveda.OrderBy(o => o.BojaGoveda).ToList();
            foreach (var govedo in sortiranaGovedaPoBoji)
            {
                unosGoveda = govedo.NazivGoveda + " - " + govedo.SpolGoveda + " - " + govedo.BojaGoveda;
                ListaIspisaGoveda.Items.Add(unosGoveda);
            }
        }

        private void BtnSortSpol_Click(object sender, EventArgs e)
        {
            ResetirajListu();
            string unosGoveda = "";
            List<Govedo> sortiranaGovedaPoSpolu = Govedo.SvaGoveda.OrderBy(entinet => entinet.SpolGoveda).ToList();
            foreach (var govedo in sortiranaGovedaPoSpolu)
            {
                unosGoveda = govedo.NazivGoveda + " - " + govedo.SpolGoveda + " - " + govedo.BojaGoveda;
                ListaIspisaGoveda.Items.Add(unosGoveda);
            }
        }
    }
}
