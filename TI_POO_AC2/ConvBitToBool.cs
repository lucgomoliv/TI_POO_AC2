using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ConvBitToBool
    {
        public bool[] Operar(string bin)
        {
            bool[] aux = new bool[bin.Length];
            for(int i = 0; i < bin.Length; i++)
            {
                if (bin[i] == '1') aux[i] = true;
                else aux[i] = false;
            }
            return aux;
        }

        public string Operar(bool[] num)
        {
            StringBuilder aux = new StringBuilder();
            foreach(bool bit in num)
            {
                if (bit) aux.Append(1);
                else aux.Append(0);
            }
            return aux.ToString();
        }
    }
}
