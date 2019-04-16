using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5G6
{
    public partial class Form1 : Form
    {
        public List<ILetjelica> SveLetjelice = new List<ILetjelica>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kanader prviKanader = new Kanader("Kanader1");
            Kanader drugiKanader = new Kanader("Kanader2");
            Helikopter prviHeli = new Helikopter("Helikopter1");
            Helikopter drugiHeli = new Helikopter("Helikopter2");
            Helikopter treciHeli = new Helikopter("Helikopter3");
            PropAvion prviProp = new PropAvion("Prop1");
            PropAvion drugiProp = new PropAvion("Prop2");
            PropAvion treciProp = new PropAvion("Prop3");
            SveLetjelice.Add(prviKanader);
            SveLetjelice.Add(drugiKanader);
            SveLetjelice.Add(prviHeli);
            SveLetjelice.Add(treciHeli);
            SveLetjelice.Add(prviProp);
            SveLetjelice.Add(drugiProp);
            SveLetjelice.Add(treciProp);
        }
        public void ZapocniDijagnostiku()
        {
            LstDijagnostika.Items.Clear();
            foreach (var letjelica in SveLetjelice)
            {
                letjelica.Samodijagnostika();
                LstDijagnostika.Items.Add(letjelica.ToString());
            }
        }
        private void BtnZapocniDijagnostiku_Click(object sender, EventArgs e)
        {
            ZapocniDijagnostiku();
        }
    }
}
