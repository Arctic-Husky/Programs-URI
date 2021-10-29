using System;

namespace Ricardo29102021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7};
            Console.WriteLine($"{PrintRec(arr,6,1)}");
            
        }

        static int PrintRec(int[] A, int n, int x)
        {
            if (n < 0)
            {
                return -1;
            }

            if(A[n] == x)
            {
                return n;
            }
            else
            {
                return PrintRec(A, n - 1, x);
            }
        }
    }
}
