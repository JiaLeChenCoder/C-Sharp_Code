using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_24_GreetSb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
           Console.WriteLine(Hello(s));
            Console.ReadKey();
        }
        public static string Hello(string name)
        {
            return "Hello" + name + "!";
        }
    }
}
