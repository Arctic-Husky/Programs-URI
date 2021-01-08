using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        const int lin = 4;
        static void Main(string[] args)
        {
            int num, temp, coef = 1;
            for(int i = 1; i <= lin; i++)
            {
                for (int j = 1; j <= i; j++, coef++)
                {
                    num = i*j;
                    Console.Write(num + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey(true);
        }
    }
}
