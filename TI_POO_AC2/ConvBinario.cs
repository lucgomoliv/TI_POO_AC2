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
            decimal[] partes = SepararDecimal(num);
            string conv = Converter((int) partes[0]) + ",";
            do
            {
                partes[1] *= 2;
                partes = SepararDecimal(partes[1]);
                conv += partes[0];
                if (conv.Split(',')[1].Length + conv.Split(',')[0].Length - 1 == 23)
                {
                    if (partes[1] != 0) conv = AddBit(conv);
                    partes[1] = 0;
                }

            } while (partes[1] != 0);
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

        /// <summary>
        /// Retorna o valor inteiro e decimal de um número, respectivamente
        /// </summary>
        /// <param name="Número"></param>
        /// <returns></returns>
        private decimal[] SepararDecimal(object num)
        {
            decimal[] aux = new decimal[]
            {
                int.Parse(num.ToString().Split(',')[0]),
                decimal.Parse(num.ToString().Split(',')[1].Insert(0, "0,"))
            };
            return aux;
        }
    }
}
