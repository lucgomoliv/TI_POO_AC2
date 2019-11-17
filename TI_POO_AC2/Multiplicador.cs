using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class Multiplicador : Circuito
    {
        public bool Operar(bool a, bool b)
        {
            return and.Operar(a, b);
        }
    }
}
