using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_POO_AC2
{
    public public class OR
    {
        /// <summary>
        /// Faz a operação OR bit a bit entre 2 valores booleanos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Operar(bool a, bool b)
        {
            return a | b;
        }

        /// <summary>
        /// Faz a operação OR bit a bit entre 2 ou mais valores booleanos
        /// </summary>
        /// <param name="bits">Array contendo os bits a serem operados</param>
        /// <returns></returns>
        public bool Operar(bool[] bits)
        {
            bool aux = bits[0];
            for (int i = 1; i < bits.Length; i++) aux |= bits[i];
            return aux;
        }
    }
}
