using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_28_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Cat();//new Dog()
            a.Bark();
            Console.ReadKey();
        }
    }
}
