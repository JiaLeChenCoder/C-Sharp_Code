using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8_JudgePrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数，判断其是否为质数");
            string StrNumber = Console.ReadLine();
            int number = GetNumber(StrNumber);
            bool b = IsPrime(number);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误。请重新输入");
                    strNumber= Console.ReadLine();
                }
            }
        }
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                //让这个数从2开始除，除到自身的前一位
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;//给非质数准备
                    }
                }
                    return true;//给质数准备
            }
        }
    }
}
