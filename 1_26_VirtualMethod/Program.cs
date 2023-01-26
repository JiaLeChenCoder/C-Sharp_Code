using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_26_VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //虚方法练习
            RealDuck rd = new RealDuck();
            MuDuck md = new MuDuck();
            XpDuck xd = new XpDuck();
            RealDuck[] ducks = { rd, md, xd };
            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i].Bark();
            }
            Console.ReadKey();
        }
    }
}
