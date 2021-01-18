using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca_2
{
    class StringParaChar // Esta função transforma strings em uma lista de caracteres
    {
        List<Char> palavraChars = new List<Char>();
        List<Char> Encriptada = new List<Char>();
        public Char Letra { get; private set; }

        public List<Char> retornaChars(String palavraStr)
        {
            for (int i = 0; i < palavraStr.Length; i++)
            {
                palavraChars.Add(palavraStr[i]);
            }

            return palavraChars;
        }

        public List<Char> retornaEncriptada(String palavraStr)
        {
            for (int i = 0; i < palavraStr.Length * 2; i++)
            {
                if (i % 2 == 0)
                {
                    Encriptada.Add(' ');
                }
                else
                    Encriptada.Add('_');
            }
            return Encriptada;
        }

        public Char pegaLetra(String letraStr)
        {
            for(int i = 0; i < 1; i++)
            {
                Letra = letraStr[i];
            }

            return Letra;
        }
    }
}
