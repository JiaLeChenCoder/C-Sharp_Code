using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_17_AscendingOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int i = 0;
            Console.WriteLine("请输入10个整数");
            for ( i = 0; i <10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine("按升序排列结果如下");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
