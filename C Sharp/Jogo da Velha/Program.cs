using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_da_Forca_2
{
    /* 
     A fazer:

            1- Mestre escreve uma palavra
            2- Ela aparece na tela porem na forma de _ _ _ _ _
            3- O jogador digita uma letra
            4- Letra aparece no lugar do _ correspondente
            5- Caso o numero de tentativas acabe o jogo termina
            6- Caso a palavra seja formada por inteiro o jogo termina

     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\n\n\tMestre, escreva a palavra sem acentos: ");
            String palavra = Console.ReadLine();
            Console.Clear();
            int encontrouTotal = 0;
            bool venceu = false;
            char letra;

            ManagerPalavra manager = new ManagerPalavra(palavra);

            Char[] encriptada = new char[(manager.getQtdChars())*2];

            for(int i = 0; i < (manager.getQtdChars())*2; i++)
            {
                if (i % 2 == 0)
                {
                    encriptada[i] = ' ';
                }
                else
                    encriptada[i] = '_';
            }

            while(manager.getVidas() > 0)
            {
                String morreu = manager.getMorreu();
                Char[] palavraChars = manager.getPalavraChars();
                bool encontrou = false;
                //String palavraInteira;

                Console.Write("\n\n\t");
                Console.Write(encriptada);
                Console.Write("     ");
                Console.Write(morreu);
                Console.Write("\n\n");
                Console.Write("\n\tInsira uma letra: ");
                letra = Console.ReadKey().KeyChar;
                /*if (letra == '0')
                {
                    Console.Write("\n\n\tInsira a palavra: ");                  <--- Minha tentativa de fazer com que o jogador possa adivinhar a palavra inteira
                    palavraInteira = Console.ReadLine();
                    if (palavraInteira == palavra)
                    {
                        encontrou = true;
                        break;
                    }
                    else
                        break;
                }
                else
                    continue;*/
                Console.Write("\n\n");

                for (int i = 0; i < manager.getQtdChars(); i++)
                {
                    if (palavraChars[i] == letra)
                    {
                        if (encriptada[(i * 2) + 1] == letra) // Caso a letra ja tenha sido digitada, break, o jogador perde uma "vida"
                            break;
                        encriptada[(i * 2) + 1] = letra;
                        encontrou = true;
                        encontrouTotal++;
                    }
                }

                if (!encontrou)
                    manager.perdeVida();
                if(encontrouTotal == manager.getQtdChars())
                {
                    venceu = true;
                    break;
                }

                Console.Clear();

            }

            Console.Write("\n\n\t");
            Console.Write(encriptada);
            Console.Write("     ");
            Console.Write(manager.getMorreu());
            Console.Write("\n\n");

            if (venceu)
            {
                Console.Write("\n\n\tParabéns, você adivinhou a palavra!\n\n");
            }
            else if(!venceu)
            {
                Console.Write("\n\n\tVocê perdeu... mais sorte na proxima!\n\n");
            }

            Console.ReadKey(true);
        }
    }
}
