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
            bool arr = false;
            if (num != 0)
            {
                string bin = convBinario.Converter(num);
                int expPolarizado = Expoente(bin);
                if (num > 0 && num < 1 || num < 0 && num > 1) bin = Normalizar(bin);
                if (bin.Length > 24) bin = bin.Substring(0, 25);
                if(arr) bin = Arrendondar(num, bin);
                int sinal;
                if (num < 0) sinal = 1;
                else sinal = 0;
                string expConv = convBinario.Converter(expPolarizado);
                if (expPolarizado < 128) while (expConv.Length < 8) expConv = expConv.Insert(0, "0");
                bin = bin.Remove(bin.IndexOf(','), 1).Remove(0, 1);
                while (bin.Length < 23) bin += "0";
                return sinal + expConv + bin;
            }
            else return "00000000000000000000000000000000";
        }

        private int Expoente(string num)
        {
            if(num[0] != '0') return (num.Split(',')[0].Length - 1) + 127;
            else
            {
                int count = 0;
                for(int i = 2; i < num.Length; i++)
                {
                    if (num[i] == '1') break;
                    else count++;
                }
                return 127 - (count + 1);
            }
        }

        private string Normalizar(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '1')
                {
                    num = num.Insert(i + 1, ",").Remove(0, i);
                    break;
                }
            }
            return num;
        }

        private string Arrendondar(double num, string bin)
        {
            bool arredondar = false;
            double parteDecimal = double.Parse(num.ToString().Split(',')[1].Insert(0, "0,"));
            double aux = parteDecimal;
            aux++;
            aux--;
            if (aux > parteDecimal) arredondar = true;
            if (arredondar && bin.Split(',')[1].Length + bin.Split(',')[0].Length - 1 == 23)
                bin = AddBit(bin);
            return bin;
        }

        private string AddBit(string num)
        {
            bool vaiUm = true;
            for (int i = num.Length - 1; vaiUm; i--)
            {
                if (vaiUm)
                {
                    if (num[i] == '1')
                    {
                        num = num.Remove(num.Length - 1) + '0';
                        vaiUm = true;
                    }
                    else
                    {
                        num = num.Remove(i, 1).Insert(i, "1");
                        vaiUm = false;
                    }
                }
            }
            return num;
        }
    }
}
