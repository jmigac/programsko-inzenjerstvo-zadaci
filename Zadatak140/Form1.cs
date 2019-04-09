using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerProvjere_Tick(object sender, EventArgs e)
        {
            int prviBroj, drugiBroj, treciBroj;
            if (TxtPrviBroj.Text.Length>0 && TxtDrugiBroj.Text.Length > 0 && TxtTreciBroj.Text.Length > 0)
            {
                prviBroj = int.Parse(TxtPrviBroj.Text);
                drugiBroj = int.Parse(TxtDrugiBroj.Text);
                treciBroj = int.Parse(TxtTreciBroj.Text);
                for (int i = prviBroj; i < drugiBroj; i++)
                {
                    if(i%treciBroj == 0)
                    {
                        ListaBrojeva.Items.Add(i);
                    }
                }
                TimerProvjere.Enabled = false;
            }
            else
            {
                
                ListaBrojeva.Items.Clear();
            }
            
                

        }

        private void TxtPrviBroj_TextChanged(object sender, EventArgs e)
        {
            TimerProvjere.Enabled = true;
        }

        private void TxtDrugiBroj_TextChanged(object sender, EventArgs e)
        {
            TimerProvjere.Enabled = true;
        }

        private void TxtTreciBroj_TextChanged(object sender, EventArgs e)
        {
            TimerProvjere.Enabled = true;
        }
    }
}
