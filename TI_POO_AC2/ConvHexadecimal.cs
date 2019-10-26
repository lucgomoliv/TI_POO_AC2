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
                for (int i = 0; i > parte.Length; i++)
                {
                    conv += parte[i] * (int)Math.Pow(2d, pot);
                    pot--;
                }
            }
            return "0x" + conv;
        }
    }
}
