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
        Substrator substrator = new Substrator();

        public bool Operar(bool a, bool b, bool[] op, bool vemUm, out bool vaiUm)
        {
            bool[] controle = demultiplexador.Operar(op[0], op[1], op[2]);
            bool[] controleOps = new bool[4];
            Array.Copy(controle, 0, controleOps, 0, 4);
            bool[] resOps = operacoes.Operar(a, b, controleOps);
            bool[] aux = new bool[2];
            if (op[0] == true && op[1] == false && op[2] == false) aux[0] = somador.Operar(a, b, vemUm, out vaiUm, controle[4]);
            else aux[1] = substrator.Operar(a, b, vemUm, out vaiUm, controle[5]);
            return or.Operar(new bool[] {
                resOps[0], //A AND B
                resOps[1], //A OR B
                resOps[2], //A'
                resOps[3], //B'
                aux[0],
                aux[1]
            });
        }
    }
}
