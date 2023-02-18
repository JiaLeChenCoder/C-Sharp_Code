using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_18_SameElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { 3, 4, 5, 6, 7, 8, 9 };
            List<int> res = new List<int>();
            foreach (int i in arr1)
            {
                foreach (int j in arr2)
                {
                    if (i == j)
                        res.Add(i);
                }
            }
            Console.Write("相同的元素有：");
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
