using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class OperacoesLogicas : Circuito
    {
        public bool[] Operar(bool a, bool b, bool[] controle)
        {
            return new bool[]
            {
                and.Operar(and.Operar(a, b), controle[0]),
                and.Operar(or.Operar(a,b),controle[0]),
                and.Operar(not.Operar(a),controle[0]),
                and.Operar(not.Operar(b),controle[0]),
            };
        }
    }
}
