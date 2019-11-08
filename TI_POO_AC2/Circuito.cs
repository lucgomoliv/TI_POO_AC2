using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public abstract class Circuito
    {
        protected NOT not = new NOT();
        protected AND and = new AND();
        protected XOR xor = new XOR();
        protected OR or = new OR();
    }
}
