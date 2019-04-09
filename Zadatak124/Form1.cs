using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BMI.VisokBMI = 3.2;
            BMI.SrednjiBMI = 1.9;
            BMI.NiskiBMI = 1.1;
            TxtVisok.Text = BMI.VisokBMI.ToString();
            TxtSrednji.Text = BMI.SrednjiBMI.ToString();
            TxtNiski.Text = BMI.NiskiBMI.ToString();
        }

        private void BtnPostavke_Click(object sender, EventArgs e)
        {
            TxtVisok.Text = BMI.VisokBMI.ToString();
            TxtSrednji.Text = BMI.SrednjiBMI.ToString();
            TxtNiski.Text = BMI.NiskiBMI.ToString();
        }

        private void BtnIzracunaj_Click(object sender, EventArgs e)
        {
            double bodyMassIndex = BMI.IzracunavanjeBodyMassIndexa(TxtVisina.Text, TxtMasa.Text);
            if (bodyMassIndex > BMI.VisokBMI)
            {
                LabelaIspis.Text = String.Format($"BMI:{bodyMassIndex:0.00} - Visoki BMI");
            }
            if(bodyMassIndex>BMI.SrednjiBMI && bodyMassIndex < BMI.VisokBMI)
            {
                LabelaIspis.Text = String.Format($"BMI:{bodyMassIndex:0.00} - Srednji BMI");
            }
            if(bodyMassIndex>BMI.NiskiBMI && bodyMassIndex < BMI.SrednjiBMI)
            {
                LabelaIspis.Text = String.Format($"BMI:{bodyMassIndex:0.00} - Niski BMI");
            }
        }
    }
}
