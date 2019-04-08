using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak137
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnOtplatniPlan_Click(object sender, EventArgs e)
        {
            ListaIspisOtplate.Items.Clear();
            double glavnica = double.Parse(TxtGlavnica.Text);
            double kamata = double.Parse(TxtKamatnaStopa.Text);
            int trajanjeKredita = int.Parse(TxtTrajanjeRacuna.Text);
            double kredit = glavnica + glavnica * kamata;
            double rataKredita = kredit / double.Parse(trajanjeKredita.ToString());
            for (int i = 0; i < trajanjeKredita; i++)
            {
                ListaIspisOtplate.Items.Add(String.Format($"{i + 1}.mjesec - {kredit:0.00} - {rataKredita:0.00}HRK"));
                kredit -= rataKredita;
            }
            ListaIspisOtplate.Items.Add(String.Format($"Otplaćen kredit!"));
            TxtGlavnica.Text = "";
            TxtKamatnaStopa.Text = "";
            TxtTrajanjeRacuna.Text = "";
        }
    }
}
