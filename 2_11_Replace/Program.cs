using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11_Replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "国家关键人物张三";
            if (str.Contains("张三"))
            {
                str = str.Replace("张三", "**");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
