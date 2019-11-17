using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ULA24BITS
    {
        ULA8BITS ula = new ULA8BITS();

        public bool[] Operar(bool[] a, bool[] b, bool[] op, bool vemUm, out bool vaiUm)
        {
            bool[] result = new bool[24];
            vaiUm = false;
            for (int i = 16; i > 0; i -= 8)
            {
                ula.Operar(SubArray(a, i, 8), SubArray(b, i, 8), op, vaiUm,  out vaiUm).CopyTo(result, i);
            }
            return result;
        }

        private bool[] SubArray(bool[] data, int index, int length)
        {
            bool[] result = new bool[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
