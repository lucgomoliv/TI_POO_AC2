using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ULA8BITS
    {
        ULA1BIT ula = new ULA1BIT();

        public bool[] Operar(bool[] a, bool[] b, bool[] op, out bool vaiUm)
        {
            bool[] result = new bool[8];
            vaiUm = false;
            for(int i = 0; i < a.Length; i++)
            {
                result[i] = ula.Operar(a[i], b[i], op, out vaiUm);
            }
            return result;
        }
    }
}
