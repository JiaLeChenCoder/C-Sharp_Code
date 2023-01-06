using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_SumBetween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            string str1 = Console.ReadLine();
            int number1 = GetNumber(str1);
            Console.WriteLine("请输入第二个数字");
            string str2 = Console.ReadLine();
            int number2 = GetNumber(str2);
            //判断第一个数字是否小于第二个数字
            JudgeNumber(ref number1, ref number2);
            //求和
            int sum = GetSum(number1, number2);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        public static int GetNumber(string s)
        {
            while (true)
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                }
        }
        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数字不能大于或等于第二个数字，请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    //调用Getnumber
                    n1 = GetNumber(s1);
                    Console.WriteLine("请重新输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }
            }
        }
        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
