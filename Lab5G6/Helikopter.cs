﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5G6
{
    public class Helikopter:ILetjelica
    {
        public String Naziv { get; set; }
        public Helikopter(string naziv)
        {
            Naziv = naziv;
        }
        public bool Samodijagnostika()
        {
            int broj;
            Random randomBroj = new Random();
            broj = randomBroj.Next(1, 1000);
            if (broj % 54 == 0)
            {

                return false;
            }

            return true;
        }

    }
}
