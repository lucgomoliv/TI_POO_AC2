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

        public string BinToIEEE754(string bin)
        {
            int sinal = 0;
            int expPolarizado = (bin.Split(',')[0].Length - 1) + 127;
            string expConv = convBinario.Converter(expPolarizado);
            bin = bin.Trim(',').Remove(0, 1);
            while (bin.Length != 23) bin += "0";
            return sinal + expConv + bin;
        }
    }
}
