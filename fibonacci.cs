using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fib = 0, ant1 = 1, ant2 = 0, temp;

            while (true)
            {

                Console.WriteLine(fib + " ");

                if (fib > 100)
                    break;

                temp = ant1;
                ant1 = fib;
                ant2 = temp;

                fib = ant1 + ant2;

            }
            Console.ReadKey(true);
        }
    }
}
