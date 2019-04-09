using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak113
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnesiBroj_Click(object sender, EventArgs e)
        {
            if (TxtUnos.Text.Length > 0)
            {
                Brojevi noviBroj = new Brojevi(int.Parse(TxtUnos.Text));
                TxtUnos.Text = "";
                TxtUnos.Focus();
            }
        }

        private void BtnPrikaziSortiranuListu_Click(object sender, EventArgs e)
        {
            string brojevi = "";
            string originalniBrojevi = "";
            List<Brojevi> sortiranaLista = Brojevi.VratiSortiranuListu();
            foreach (var item in sortiranaLista)
            {
                brojevi += item.Broj + " ";
            }
            foreach (var item in Brojevi.SviBrojevi)
            {
                originalniBrojevi += item.Broj + " ";
            }
            originalniBrojevi += Environment.NewLine;
            brojevi += Environment.NewLine;
            brojevi += originalniBrojevi;
            MessageBox.Show(brojevi);

        }
    }
}
