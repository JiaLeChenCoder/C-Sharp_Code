using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_SequentialExchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将{“橘子”，“香蕉”，“苹果”}中的元素调换
            string[] names = { "橘子", "香蕉", "苹果" };
            Test(names);
            for (int i = 0; i <names.Length; i++)
            {
                Console.Write(names[i]);
            }
            Console.ReadKey();
        }
        public static void Test(string[] names)
        {
            for (int i = 0; i < names.Length/2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
        }
    }
}
