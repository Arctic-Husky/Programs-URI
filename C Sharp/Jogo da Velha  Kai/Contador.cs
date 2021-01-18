using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca_2
{
    class Contador // Esta classe so conta os caracteres de uma string
    {
        public int qtdChars { get; private set; }
        //public int qtdLetras { get; private set; }

        /*public Contador()
        {
            qtdLetras = 0;
        }*/

        public void contaChars(String palavra)
        {
            qtdChars = palavra.Length;
        }

        /*public void contaLetras(String palavra)
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if ((palavra[i] >= 65 && palavra[i] <= 90) || (palavra[i] >= 97 && palavra[i] <= 122))
                    qtdLetras++;
            }
        }*/
    }
}
