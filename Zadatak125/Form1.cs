using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesiNukleobazu_Click(object sender, EventArgs e)
        {
            Nukleobaze novaNukleobaza = new Nukleobaze(TxtSadrzaj.Text);
        }

        private void BtnIspisivanjeParova_Click(object sender, EventArgs e)
        {
            ListaNukleobaza.Items.Clear();
            string primjerIspisa = "";
            if (Nukleobaze.SveNukleobaze.Count % 2 == 0)
            {
                for (int i = 0; i < Nukleobaze.SveNukleobaze.Count; i+=2)
                {
                    primjerIspisa += Nukleobaze.SveNukleobaze[i] + " " + Nukleobaze.SveNukleobaze[i + 1];
                    ListaNukleobaza.Items.Add(primjerIspisa);
                    primjerIspisa = "";
                }
            }
            else
            {
                for (int i = 0; i < Nukleobaze.SveNukleobaze.Count-1; i += 2)
                {
                    primjerIspisa += Nukleobaze.SveNukleobaze[i] + " " + Nukleobaze.SveNukleobaze[i + 1];
                    ListaNukleobaza.Items.Add(primjerIspisa);
                    primjerIspisa = "";
                }
            }
        }
    }
}
// A C T G T C A T C G A C