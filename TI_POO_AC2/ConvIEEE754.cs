using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ConvIEEE754
    {
        ConvBinario convBinario = new ConvBinario();

        public string Converter(double num)
        {
            if (num != 0)
            {
                string bin = convBinario.Converter(num);
                if (bin.Length > 24) bin = bin.Substring(0, 25);
                int sinal;
                if (num < 0) sinal = 1;
                else sinal = 0;
                bin.Remove(bin.IndexOf(','), 1);
                int expPolarizado = (bin.Split(',')[0].Length - 1) + 127;
                string expConv = convBinario.Converter(expPolarizado);
                if (expPolarizado < 128) while (expConv.Length < 8) expConv = expConv.Insert(0, "0");
                bin = bin.Remove(bin.IndexOf(','), 1).Remove(0, 1);
                while (bin.Length < 23) bin += "0";
                return sinal + expConv + bin;
            }
            else return "00000000000000000000000000000000";
        }
    }
}
