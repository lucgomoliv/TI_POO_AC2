using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public class ULA1BIT : Circuito
    {
        Somador somador = new Somador();
        Demultiplexador demultiplexador = new Demultiplexador();
        OperacoesLogicas operacoes = new OperacoesLogicas();

        public bool Operar(bool a, bool b, bool[] op, out bool vaiUm)
        {
            bool vemUm = false;
            bool[] controle = demultiplexador.Operar(op[0], op[1], op[2]);
            bool[] controleOps = new bool[4];
            Array.Copy(controle, 0, controleOps, 0, 4);
            bool[] resOps = operacoes.Operar(a, b, controleOps);
            return or.Operar(new bool[] {
                resOps[0], //A AND B
                resOps[1], //A OR B
                resOps[2], //A'
                resOps[3], //B'
                somador.Operar(a, b, vemUm, out vaiUm, controle[4]) //A + B ou A - B
            });
        }
    }
}
