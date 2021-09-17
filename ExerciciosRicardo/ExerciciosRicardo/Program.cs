using System;
using System.Collections.Generic;

namespace ExerciciosRicardo
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindromos();

        }

        private static void Palindromos()
        {
            Pilha pilha1 = new Pilha();
            Pilha pilha2 = new Pilha();
            Pilha aux = new Pilha();
            string str;

            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                aux.Push(str[i]);
                pilha1.Push(str[i]);

            }
            while (!aux.IsEmpty())
            {
                pilha2.Push(aux.Pop());
            }

            Console.WriteLine(Pilha.PopCompare(pilha1, pilha2) == true ? "É um palíndromo" : "Não é um palíndromo");
        }
    }
}
