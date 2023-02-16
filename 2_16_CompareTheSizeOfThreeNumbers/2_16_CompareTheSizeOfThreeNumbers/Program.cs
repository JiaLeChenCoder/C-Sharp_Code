using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_16_CompareTheSizeOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //不考虑相等
            Console.WriteLine("请输入三个数字");
            int NumberOne = Convert.ToInt32(Console.ReadLine());
            int NumberTwo = Convert.ToInt32(Console.ReadLine());
            int NumberThree = Convert.ToInt32(Console.ReadLine());
            //如果第一个数字大于第二个数字并且大于第三个数字
            if (NumberOne > NumberTwo && NumberOne > NumberThree)
            {
                Console.WriteLine("最大数是{0}", NumberOne);
            }
            else if (NumberTwo > NumberOne && NumberTwo > NumberThree)
            {
                Console.WriteLine("最大数是{0}", NumberTwo);
            }
            else
            {
                Console.WriteLine("最大的数是{0}", NumberThree);
            }
            Console.ReadKey();
        }
    }
}
