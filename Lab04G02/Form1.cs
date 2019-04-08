using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04G02
{
    public partial class Form1 : Form
    {
        public static int Sekunda;
        public static int MiliSekunda;
        public static int Minuta;
        public static int BrojKruga;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerVremena_Tick(object sender, EventArgs e)
        {
            if (Stoperica.AktivnaStoperica)
            {
                MiliSekunda++;
                if (MiliSekunda >= 59)
                {
                    Sekunda++;
                    MiliSekunda = 0;
                }
                if (Sekunda >= 59)
                {
                    Minuta++;
                    Sekunda = 0;
                }
                IscrtajVrijeme();
            }
        }
        private void IscrtajVrijeme()
        {
            LabelMiliSekunde.Text = String.Format("{0}", MiliSekunda);
            LabelSekunde.Text = String.Format("{0}", Sekunda);
            LabelMinute.Text = String.Format("{0}", Minuta);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Sekunda = 0;
            MiliSekunda = 0;
            Minuta = 0;
            BrojKruga = 0;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Stoperica.AktivnaStoperica = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Stoperica.AktivnaStoperica = false;
        }

        private void BtnKrug_Click(object sender, EventArgs e)
        {
            string vrijemeKruga = "";
            vrijemeKruga = String.Format($"{Minuta}:{Sekunda}:{MiliSekunda} - {BrojKruga}-ti krug");
            ListaVremenaKrugova.Items.Add(vrijemeKruga);
            BrojKruga++;
        }
    }
}
