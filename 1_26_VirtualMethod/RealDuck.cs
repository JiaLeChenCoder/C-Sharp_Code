using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_26_VirtualMethod
{
    internal class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("是真的鸭子");
        }
    }
}
