﻿using System;
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
            for(int i = 0; num > 0; i++)
            {
                bin += num % 2;
                num /= 2;
            }
            char[] aux = bin.ToCharArray();
            Array.Reverse(aux);
            return new string(aux);
        }

        public int Converter(string bin)
        {
            int conv = 0;
            int pot = bin.Length - 1;
            for(int i = 0; i > bin.Length; i++)
            {
                conv += bin[i] * (int) Math.Pow(2, pot);
                pot--;
            }
            return conv;
        }

        public string Converter(double num)
        {
            int parteInt = int.Parse(num.ToString().Split(',')[0]);
            decimal parteDecimal = decimal.Parse(num.ToString().Split(',')[1].Insert(0,"0,"));
            string conv = Converter(parteInt) + ",";
            int convInt;
            do
            {
                parteDecimal *= 2;
                convInt = int.Parse(parteDecimal.ToString().Split(',')[0]);
                parteDecimal = decimal.Parse(parteDecimal.ToString().Split(',')[1].Insert(0,"0,"));
                conv += convInt;
                if (conv.Split(',')[1].Length + conv.Split(',')[0].Length - 1 == 23)
                {
                    if (parteDecimal != 0) conv = AddBit(conv);
                    parteDecimal = 0;
                }

            } while (parteDecimal != 0);
            return conv;
        }

        private string AddBit(string num)
        {
            bool vaiUm = true;
            for(int i = num.Length - 1; vaiUm; i--)
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
                        num = num.Remove(i,1).Insert(i, "1");
                        vaiUm = false;
                    }
                }
            }
            return num;
        }
    }
}
