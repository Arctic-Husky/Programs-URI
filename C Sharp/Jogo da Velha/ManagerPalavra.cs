using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca_2
{
    class ManagerPalavra
    {
        private int qtdChars;
        private int qtdLetras = 0;
        private int vidas = 6;
        private String morreu;
        public String Palavra { get; private set; }
        public ManagerPalavra(String palavra)
        {
            this.Palavra = palavra;
            qtdChars = Palavra.Length;
        }

        private Char[] palavraChars = new char[100];

        public Char[] getPalavraChars()
        {
            for(int i = 0; i < Palavra.Length; i++)
            {
                palavraChars[i] = Palavra[i];
            }

            return palavraChars;
        }

        public int getQtdChars()
        {
            qtdChars = Palavra.Length;
            return qtdChars;
        }

        public int getQtdLetras()
        {
            for(int i = 0; i < Palavra.Length; i++)
            {
                if((Palavra[i] >= 65 && Palavra[i] <= 90) || (Palavra[i] >= 97 && Palavra[i] <= 122))
                        qtdLetras++;
            }

            return qtdLetras;
        }

        public String getMorreu()
        {
            if (vidas == 6)
                morreu = "      ";
            else if (vidas >= 5)
                morreu = "P     ";
            else if (vidas >= 4)
                morreu = "PE    ";
            else if (vidas >= 3)
                morreu = "PER   ";
            else if (vidas >= 2)
                morreu = "PERD  ";
            else if (vidas >= 1)
                morreu = "PERDE ";
            else if (vidas >= 0)
                morreu = "PERDEU";

            return morreu;
        }

        public int getVidas()
        {
            return vidas;
        }

        public void perdeVida()
        {
            vidas--;
        }
    }
}
