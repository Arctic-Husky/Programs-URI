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
    class Program /*
                     O que mudou nesta versão: 
                       - Programa dividido em mais classes
                       - Mudança da função ReadKey para ReadLine
                       
                       Link para testar: https://repl.it/@ArcticHusky/Jogo-da-Forca-Kai#main.cs
                   */
    {
        static void Main(string[] args)
        {
            Vidas vidas = new Vidas();
            StringParaChar StrToChar = new StringParaChar();
            Contador cont = new Contador();

            List<Char> palavraChars = new List<Char>();
            List<Char> Encriptada = new List<Char>();

            int qtdChars;
            //int qtdLetras;
            int encontrouTotal = 0;
            bool venceu = false;
            Char letra;

            Console.Write("\n\n\tMestre, escreva a palavra sem acentos: ");
            String palavra = Console.ReadLine();

            Console.Clear();

            cont.contaChars(palavra);

            palavraChars = StrToChar.retornaChars(palavra);
            Encriptada = StrToChar.retornaEncriptada(palavra);
            qtdChars = cont.qtdChars;
            //qtdLetras = cont.qtdLetras;

            while(vidas.Status)
            {
                String morreu = vidas.derrota;
                bool encontrou = false;

                Console.Write("\n\n\t");
                foreach(Char c in Encriptada)
                    Console.Write(c);
                Console.Write("     ");
                Console.Write(morreu);
                Console.Write("\n\n");
                Console.Write("\n\tInsira uma letra: ");
                letra = StrToChar.pegaLetra(Console.ReadLine());

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

                for (int i = 0; i < qtdChars; i++)
                {
                    if (palavraChars[i] == letra)
                    {
                        if (Encriptada[(i * 2) + 1] == letra) // Caso a letra ja tenha sido digitada, break, o jogador perde uma "vida"
                            break;
                        Encriptada[(i * 2) + 1] = letra;
                        encontrou = true;
                        encontrouTotal++;
                    }
                }

                if (!encontrou)
                    vidas.perdeVida();
                if(encontrouTotal == qtdChars)
                {
                    venceu = true;
                    break;
                }

                Console.Clear();

            }

            Console.Write("\n\n\t");
            foreach (Char c in Encriptada)
                Console.Write(c);
            Console.Write("     ");
            Console.Write(vidas.derrota);
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
