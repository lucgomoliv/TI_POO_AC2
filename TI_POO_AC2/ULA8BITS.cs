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

        public bool[] Operar(bool[] a, bool[] b, bool[] op, bool vemUm, out bool vaiUm)
        {
            bool[] result = new bool[8];
            vaiUm = false;
            
            if (op.Equals(new bool[1, 1, 0]) || op.Equals(new bool[1, 1, 1]))
            {
                bool[][] aux2 = new bool[8][];
                for (int i = 0; i < b.Length; i++)
                {
                    bool[] aux = new bool[8];
                    for (int j = 0; j < a.Length; j++)
                    {
                        aux[j] = ula.Operar(a[j], b[i], op, vaiUm, out vaiUm);
                    }
                    aux2[i] = aux;
                }
                for(int i = 0; i < aux2.Length-1; i++)
                {
                    Operar(aux2[i], aux2[i + 1],new bool[] { true, false, false }, vaiUm, out vaiUm);
                }
            }
            else
            {
                for (int i = 7; i > 0; i--)
                {
                    result[i] = ula.Operar(a[i], b[i], op, vaiUm, out vaiUm);
                }
            }
            return result;
        }
    }
}
