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
            string bin = convBinario.Converter(num);
            int sinal = 0;
            bin.Remove(bin.IndexOf(','), 1);
            int expPolarizado = (bin.Split(',')[0].Length - 1) + 127;
            string expConv = convBinario.Converter(expPolarizado);
            bin = bin.Remove(bin.IndexOf(','), 1).Remove(0, 1);
            while (bin.Length < 23) bin += "0";
            return sinal + expConv + bin;
        }
    }
}
