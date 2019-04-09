using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak133
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtPrviBroj.Text == "0" || TxtPrviBroj.Text=="1" 
                && TxtDrugiBroj.Text == "0" || TxtDrugiBroj.Text == "1"
                && TxtTreciBroj.Text == "0" || TxtTreciBroj.Text == "1" )
            {
                string binarniBroj = "";
                binarniBroj += TxtPrviBroj.Text + TxtDrugiBroj.Text + TxtTreciBroj.Text +
                               TxtCetvrtiBroj.Text + TxtPetiBroj.Text + TxtSestBroj.Text +
                               TxtSedmiBroj.Text + TxtOsmiBroj.Text;
                LabelaDekatski.Text = Convert.ToInt32(binarniBroj,2).ToString();
            }
            else
            {
                MessageBox.Show("Unijeli ste ne binarnu znamenku!");
            }

        }
    }
}
