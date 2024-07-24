using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    //program to swap two numbers without using a temp variable.

    internal class Program3_SwapNumber
    {
        static void Main(string[] args)
        {
            int Number1 = 10;
            int Number2 = 20;

            //Before swapping
            Console.WriteLine("Before Swapping");
            Console.WriteLine("Number1 : " + Number1);
            Console.WriteLine("Number2 : " + Number2);

            //Swaping of Numbers
            if(Number1 != Number2)
            {
                Number1 = Number1 + Number2;
                Number2 = Number1 - Number2;
                Number1 = Number1 - Number2;
            }

            //After swapping
            Console.WriteLine("After Swapping");
            Console.WriteLine("Number1 : " + Number1);
            Console.WriteLine("Number2 : " + Number2);
        }
    }
}
