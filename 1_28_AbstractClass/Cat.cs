using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_28_AbstractClass
{
    internal class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("小猫叫");
        }
    }
}
