using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_26_VirtualMethod
{
    internal class XpDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("是橡皮鸭子");
        }
    }
}
