using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_110
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ProvjeraPalindroma(string rijec)
        {
            for (int i = 0; i < rijec.Length/2; i++)
            {
                if (rijec[i].Equals(rijec[rijec.Length - 1 - i]))
                {
                    TimerPromjene.Enabled = false;
                    MessageBox.Show("Palindrom");
                    break;
                }
            }
        }
        private bool ProvjeraSlovaUListi(List<char> slova, char slovo)
        {
            foreach (var item in slova)
            {
                if (item.Equals(slovo))
                    return true;
            }
            return false;
        }
        private int NadiSlovo(int[] polje, int vrijednost)
        {
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i].Equals(vrijednost))
                    return i;
            }
            return 0;
        }
        private void StatistikaRijeci(string rijec)
        {
            if (rijec.Length > 0)
            {
                string brojSlova = rijec.Length.ToString();
                List<char> slova = new List<char>();
                for (int i = 0; i < rijec.Length; i++)
                {
                    if (!ProvjeraSlovaUListi(slova, rijec[i]))
                    {
                        slova.Add(rijec[i]);
                    }
                }
                int[] brojPonavljanjaSlova = new int[slova.Count];
                for (int i = 0; i < slova.Count; i++)
                {
                    brojPonavljanjaSlova[i] = 0;
                }
                for (int i = 0; i < slova.Count; i++)
                {
                    for (int j = 0; j < rijec.Length; j++)
                    {
                        if (slova[i].Equals(rijec[j]))
                            brojPonavljanjaSlova[i]++;
                    }
                }
                int najcesceSlovo, najrjedeSlovo;
                Array.Sort(brojPonavljanjaSlova);
                najcesceSlovo = brojPonavljanjaSlova[brojPonavljanjaSlova.Length-1];
                najrjedeSlovo = brojPonavljanjaSlova[0];
                int najcesceSlovoIndex = NadiSlovo(brojPonavljanjaSlova, najcesceSlovo);
                int najrjedeSlovoIndex = NadiSlovo(brojPonavljanjaSlova, najrjedeSlovo);
                string ispis = String.Format($"Najcesce:{slova[najcesceSlovoIndex]}-{najcesceSlovo} | Najrjede:{slova[najrjedeSlovoIndex]}-{najrjedeSlovo}");
                ListaStatistike.Items.Add(ispis);
                ispis = "";
                TimerPromjene.Enabled = false;
            }
        }
        private void TimerPromjene_Tick(object sender, EventArgs e)
        {
            ProvjeraPalindroma(TxtUneseniTekst.Text);
            StatistikaRijeci(TxtUneseniTekst.Text);
        }

        private void TxtUneseniTekst_TextChanged(object sender, EventArgs e)
        {
            TimerPromjene.Enabled = true;
        }
    }
}
