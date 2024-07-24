using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    /*
     Write a program that prints numbers from 1 to 100. 
       i) But for multiples of 3 print “valar” instead of the number 
      ii) For multiples of 5 print “morghulis” instead of the number 
     iii) For the numbers that are multiples of both 3 and 5 print “valar morghulis”
     
     */
    internal class Program2_PrintNo1to100
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("valar morghulis");
                else if(i % 3 == 0)
                    Console.WriteLine("valar");
                else if(i % 5 == 0)
                    Console.WriteLine("morghulis");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
