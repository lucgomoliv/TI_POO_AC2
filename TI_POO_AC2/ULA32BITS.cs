using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    class ULA32BITS
    {
        ULA24BITS ula = new ULA24BITS();
        ULA1BIT ula2 = new ULA1BIT();

        public bool[] Operar(bool[] a, bool[] b, bool[] op, out bool vaiUm)
        {
            bool[] result = new bool[32];
            vaiUm = false;
            bool[] aux = ula.Operar(SubArray(a, 8, 24), SubArray(b, 8, 24), op, false, out vaiUm);
            if (vaiUm) Array.Copy(AddBit(SubArray(a, 1, 8)), 0, result, 1, 8);
            result[0] = a[0];
            Array.Copy(aux, 0, result, 9, 23);
            return result;
        }

        private bool[] SubArray(bool[] data, int index, int length)
        {
            bool[] result = new bool[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        private bool[] AddBit(bool[] num)
        {
            bool vaiUm = true;
            for (int i = num.Length - 1; vaiUm; i--)
            {
                if (vaiUm)
                {
                    if (num[i] == true)
                    {
                        num[i] = false;
                        vaiUm = true;
                    }
                    else
                    {
                        num[i] = true;
                        vaiUm = false;
                    }
                }
            }
            return num;
        }
    }
}
