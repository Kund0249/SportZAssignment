using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportZAssignment
{
    //over loaded function in c# to calculate an area of a square or a rectangle.

    class AreaCalculator
    {
        public int Area(byte SideOfSquare)
        {
            return SideOfSquare * SideOfSquare;
        }
        public int Area(ushort SideOfSquare)
        {
            return SideOfSquare * SideOfSquare;
        }
        public float Area(float SideOfSquare)
        {
            return SideOfSquare * SideOfSquare;
        }
        public int Area(byte Length,byte width)
        {
            return Length * width;
        }
        public int Area(ushort Length, ushort width)
        {
            return Length * width;
        }
        public float Area(byte Length, float width)
        {
            return Length * width;
        }
        public float Area(float Length, byte width)
        {
            return Length * width;
        }
        public float Area(float Length, float width)
        {
            return Length * width;
        }

    }
    internal class Program8_RectangleArea
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            int AreaOfSquare = areaCalculator.Area(10);
            int AreaOfRectangle = areaCalculator.Area(10,20);

            Console.WriteLine("Area of Square : " + AreaOfSquare);
            Console.WriteLine("Area of Rectangle : " + AreaOfRectangle);
        }
    }
}
