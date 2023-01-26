using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_26_VirtualMethod
{
    internal class MuDuck:RealDuck
    {
        public virtual void Back()
        {
            Console.WriteLine("是木头鸭子");
        }
    }
}
