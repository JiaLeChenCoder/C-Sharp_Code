using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Interface_SquareCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square S1 = new Square();
            S1.Area(2);
            Circle S2 = new Circle();
            S2.Area(3);
            Console.WriteLine("边长为2的面积是{0}", S1.Area(2));
            Console.WriteLine("半径为3的面积是{0}", S2.Area(3));
            Console.ReadKey();
        }
    }
}
