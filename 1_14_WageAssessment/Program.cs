using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_14_WageAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //小陈的年终工资评定，如果是A级，那工资就涨500，如果被评为B级，工资就涨200，如果为C级，工资不变，如果为D级，工资降200元，如果为E级，工资降500元。
            bool b = true;
            double salary = 8000;
            Console.WriteLine("请输入对小陈的年终评定");
            string level = Console.ReadLine();
            switch (level)
            {
                case "A":salary += 500;
                    break;
                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:Console.WriteLine("输入有误，程序退出");
                    b = false;
                    break;
            }
            if (b)
            {
                Console.WriteLine("小陈的工资是{0}元", salary);
            }
            Console.ReadKey();
        }
    }
}
