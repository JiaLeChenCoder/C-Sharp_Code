using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_MethodPerimeterArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算圆的周长和面积
            double r = 5;
            double perimeter;
            double area;
            GetPerimeterArea(r, out perimeter, out area);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.ReadKey();

        }
        public static void GetPerimeterArea(double r,out double perimeter,out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }
    }
}
