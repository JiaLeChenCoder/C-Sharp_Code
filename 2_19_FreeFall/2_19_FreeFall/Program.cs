using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_19_FreeFall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //一个球从100米的高度落下，每次落地后跳回原高度的一半，再落下。求它在第十次落地时，共经历了多少米
            double sum = 0.0;
            double h = 100.0;
                for (int i = 0; i < 10; i++)
            {
                sum += h;//累计经历的路程
                h /= 2;//高度减半
            }
            Console.WriteLine("经历了{0}米",sum);
            Console.ReadKey();
        }
    }
}
