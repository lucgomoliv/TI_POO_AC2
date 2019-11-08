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

        public bool[] Operar(bool[] a, bool[] b, bool[] op, out bool vaiUm)
        {
            bool[] result = new bool[24];
            vaiUm = false;
            for (int i = 0; i < a.Length; i+=8)
            {
                result.CopyTo(ula.Operar(SubArray(a, i, 8), SubArray(b, i, 8), op, out vaiUm), i);
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
