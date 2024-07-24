using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    //Given an array of integers, C# method to total all the values that are even numbers
    internal class Program1_SumOfEvenInArray
    {
        public int SumOfEven(int[] array)
        {
            int sum = 0;
            foreach (int n in array)
            {
                if (n % 2 == 0)
                    sum += n;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int Result = new Program1_SumOfEvenInArray().SumOfEven(Numbers);

            Console.WriteLine("Sum of even numbers : " + Result);
        }
    }
}
