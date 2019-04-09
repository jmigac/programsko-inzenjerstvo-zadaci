using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtTecaj.Text = "7.42";
            PretvorbuValuta.Tecaj = double.Parse(TxtTecaj.Text);
        }

        private void BtnPostavi_Click(object sender, EventArgs e)
        {
            if (TxtTecaj.Text.Length > 0)
            {
                PretvorbuValuta.Tecaj = double.Parse(TxtTecaj.Text);
                List<PretvorbuValuta> pretvorbeValuta = PretvorbuValuta.VratiPovijestPretvorbi();
                ListaPretvorbi.Items.Clear();
                foreach (var pretvorba in pretvorbeValuta)
                {
                    ListaPretvorbi.Items.Add(String.Format($"{pretvorba.Valuta} - {PretvorbuValuta.Tecaj} - {pretvorba.PretvorenaValuta}"));
                }
            }
        }

        private void BtnIzracunaj_Click(object sender, EventArgs e)
        {
            if (TxtValuta1.Text.Length > 0)
            {
                PretvorbuValuta novaPretvorba = new PretvorbuValuta(double.Parse(TxtValuta1.Text));
                List<PretvorbuValuta> pretvorbeValuta = PretvorbuValuta.VratiPovijestPretvorbi();
                ListaPretvorbi.Items.Clear();
                foreach (var pretvorba in pretvorbeValuta)
                {
                    ListaPretvorbi.Items.Add(String.Format($"{pretvorba.Valuta} - {PretvorbuValuta.Tecaj} - {pretvorba.PretvorenaValuta}"));
                }
            }
        }
    }
}
