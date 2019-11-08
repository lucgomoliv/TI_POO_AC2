using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class Demultiplexador : Circuito
    {
        public bool[] Operar(bool a, bool b, bool c)
        {
            return new bool[]
            {
                and.Operar(new bool[]{!a,!b,!c}),
                and.Operar(new bool[]{!a,!b,c}),
                and.Operar(new bool[]{!a,b,!c}),
                and.Operar(new bool[]{!a,b,c}),
                and.Operar(new bool[]{a,!b,!c}),
                and.Operar(new bool[]{a,!b,c}),
                and.Operar(new bool[]{a,b,!c}),
                and.Operar(new bool[]{a,b,c})
            };
        }
    }
}
