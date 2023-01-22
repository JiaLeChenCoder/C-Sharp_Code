using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_22_Indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一句话，找出e所在的位置
            string str = Console.ReadLine();
            int index = str.IndexOf('e');
            Console.WriteLine("第1次出现e的位置是{0}", index);
            int count = 1;//用来记录e出现的次数
            while (index != -1)
            {
                count++;
                index = str.IndexOf('e', index + 1);
                if (index == -1)
                {
                    break;
                }
                Console.WriteLine("第{0}次出现e的位置是{1}", count, index);
            }
            Console.ReadKey();
        }
    }
}
