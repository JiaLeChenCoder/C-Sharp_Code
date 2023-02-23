using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_23_NarcissisticNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义两个int型变量  
            int number, sum = 0;
            //循环从100到999
            for (number = 100; number < 1000; number++)
            {
                //拆分每个数字
                int units, tens, hundreds;
                units = number % 10;
                tens = (number / 10) % 10;
                hundreds = (number / 10) / 10;
                //每个数字的立方和
                sum = (int)Math.Pow(units, 3) + (int)Math.Pow(tens, 3) + (int)Math.Pow(hundreds, 3);
                if (sum == number)
                {
                    //输出水仙花数
                    Console.WriteLine(number + " 是一个水仙花数");
                }
            }
        }
    }
}

