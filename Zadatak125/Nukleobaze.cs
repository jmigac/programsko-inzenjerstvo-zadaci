using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak125
{
    class Nukleobaze
    {
        public static List<char> SveNukleobaze = new List<char>();

        public Nukleobaze(string uneseneNukleobaze)
        {
            for (int i = 0; i < uneseneNukleobaze.Length; i++)
            {
                if(uneseneNukleobaze[i]!=' ')
                {
                    SveNukleobaze.Add(uneseneNukleobaze[i]);
                }
            }
        }
    }
}
