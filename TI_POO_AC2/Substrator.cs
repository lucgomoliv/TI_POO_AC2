using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class Substrator : Circuito
    {
        public bool Operar(bool a, bool b, bool vemUm, out bool vaiUm, bool controle)
        {
            vaiUm = or.Operar(
                            and.Operar(new bool[] { a, !b, controle }),
                            and.Operar(new bool[] { controle, !xor.Operar(a, b), vemUm })
                        );
            return xor.Operar(vemUm, xor.Operar(a, b));
        }
    }
}
