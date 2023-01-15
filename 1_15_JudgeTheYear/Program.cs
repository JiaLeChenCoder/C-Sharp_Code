using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_15_JudgeTheYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入一个月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:day = 31;
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("输入的月份不正确");
                    }

                }
                catch
                {
                    Console.WriteLine("输入的月份不符合要求，程序退出");
                }
            }
            catch {
                Console.WriteLine("输入的年份不符合要求");
            }
        }
    }
}
