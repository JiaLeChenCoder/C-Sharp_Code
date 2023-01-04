using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_MaxScoreReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //找最大值
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            ////第一种方法
            //int max = a;
            //if (max < b)
            //{
            //    max = b;
            //}
            //else if (max < c)
            //{
            //    max = c;
            //}
            //else
            //    max = a;
            //Console.WriteLine("最大值是：{0}", max);
            //Console.ReadKey();
            //第二种方法
            //if (a > b && a > c)
            //    Console.WriteLine("最大值是{0}", a);
            //if (b > a && b > c)
            //    Console.WriteLine("最大值是{0}", b);
            //if (c > a && c > b)
            //    Console.WriteLine("最大值是{0}", c);
            //Console.ReadKey();

            //判断成绩
            //第一种方法
            //Console.WriteLine("你考了多少分");
            //string str1 = Console.ReadLine();
            //int a = Convert.ToInt32(str1);
            //if (a > 100 || a < 0)
            //{
            //    Console.WriteLine("输入错误");
            //}
            //else if (a < 101 && a > 89)
            //{
            //    Console.WriteLine("优");
            //}
            //else if (a < 90 && a > 79)
            //{
            //    Console.WriteLine("良");
            //}
            //else if (a < 80 && a > 69)
            //{
            //    Console.WriteLine("中");
            //}
            //else if (a < 70 && a > 59)
            //{
            //    Console.WriteLine("合格");           
            //}
            //else
            // {
            //    Console.WriteLine("不合格");
            //  }
            //    Console.ReadKey();
            //第二种方法
            //Console.WriteLine("请问你考了多少分？");
            //try
            //{
            //    int Number = Convert.ToInt32(Console.ReadLine());
            //    switch (Number / 10)
            //    {
            //        case 10:
            //        case 9: Console.WriteLine("你的成绩是优"); break;
            //        case 8: Console.WriteLine("你的成绩是良"); break;
            //        case 7: Console.WriteLine("你的成绩是中"); break;
            //        case 6: Console.WriteLine("你的成绩是合格"); break;
            //        default: Console.WriteLine("你的成绩是不合格"); break;
            //    }
            //}
            //catch { Console.WriteLine("输入有误，请重新输入，程序退出。"); }
            //Console.ReadKey();

            //整数反向输出
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                int b = a % 10;
                Console.Write(b);
                a /= 10;
            }
            Console.ReadKey();
        }
        }
    }

