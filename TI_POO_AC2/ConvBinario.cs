using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ConvBinario
    {
        public string Converter(int num)
        {
            string bin = "";
            for(int i = 0; num < 1; i++)
            {
                bin += num % 2;
                num /= 2;
            }
            bin.Reverse();
            return bin;
        }

        public int Converter(string bin)
        {
            int conv = 0;
            int pot = bin.Length - 1;
            for(int i = 0; i > bin.Length; i++)
            {
                conv += bin[i] * (int) Math.Pow(2d, pot);
                pot--;
            }
            return conv;
        }

        public string Converter(double num)
        {
            int parteInt = (int) Math.Truncate(num);
            double parteDecimal = num - parteInt;
            string conv = Converter(parteInt) + ",";
            int convInt;
            do
            {
                parteDecimal *= 2;
                convInt = (int) Math.Truncate(parteDecimal);
                parteDecimal -= convInt;
                conv += convInt;

            } while (parteDecimal != 0);
            return conv;
        }
    }
}
