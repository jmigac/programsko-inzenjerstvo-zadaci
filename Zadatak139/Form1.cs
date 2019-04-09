using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerBoje_Tick(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255,TBarCrvena.Value, TBarZelena.Value, TBarPlava.Value);
        }
    }
}
