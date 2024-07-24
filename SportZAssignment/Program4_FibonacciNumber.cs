using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    //program to print Nth fibonacci number in series.

    internal class Program4_FibonacciNumber
    {
        static int Fibonacci(int n)
        {
            if (n <= 0)
                return n;

            int V1 = 0, V2 = 1, V3 = 0;

            for (int i = 2; i < n; i++)
            {
                V3 = V1 + V2;
                V1 = V2;
                V2 = V3;
            }
            return V3;
        }
        static void Main(string[] args)
        {
            int Result =  Fibonacci(15);
            Console.WriteLine("Fibonacci number is " + Result);
        }
    }
}
