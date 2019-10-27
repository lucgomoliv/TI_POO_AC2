using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ConvHexadecimal
    {
        public string Converter(string num)
        {
            string conv= "";
            while (num.Length % 4 != 0) num = num.Insert(0, "0");
            string[] partes = new string[num.Length / 4];
            int count = 0;
            for(int i = 0; i < num.Length; i += 4)
            {
                partes[count] = num.Substring(i, 4);
                count++;
            }
            foreach(string parte in partes)
            {
                int pot = parte.Length - 1;
                double aux = 0;
                for (int i = 0; i < parte.Length; i++)
                {
                    aux += int.Parse(parte[i].ToString()) * (int)Math.Pow(2, pot);
                    pot--;
                }
                switch (aux)
                {
                    case 10: conv += "A"; break;
                    case 11: conv += "B"; break;
                    case 12: conv += "C"; break;
                    case 13: conv += "D"; break;
                    case 14: conv += "E"; break;
                    case 15: conv += "F"; break;
                    default: conv += aux; break;
                }
            }
            return "0x" + conv;
        }
    }
}
