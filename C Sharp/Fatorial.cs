using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // Este programa apenas calcula os fatoriais de 1 a 10
        {
            for (int i = 1; i <= 10; i++)
            {
                int fatorial = 1;
                for (int j = i; j >= 1; j--)
                {
                    fatorial *= j;
                }
                Console.WriteLine("Fatorial de " + i + "= " + fatorial);
            }
            Console.ReadKey(true);
        }
    }
}