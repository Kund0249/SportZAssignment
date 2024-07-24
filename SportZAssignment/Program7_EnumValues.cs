using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    // program to iterate through Enum values
    public enum Colors
    {
        red,
        blue,
        green,
        yellow
    }

    internal class Program7_EnumValues
    {
        static void Main(string[] args)
        {
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(color);
            }
        }
    }
}
