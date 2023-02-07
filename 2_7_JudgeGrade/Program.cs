using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7_JudgeGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接受输入后判断等级并显示出来
            int score = Convert.ToInt32(Console.ReadLine());
            string level = Getlevel(score);
            Console.WriteLine(level);
            Console.ReadKey();
        }
        public static string Getlevel(int score)
        {
            switch (score / 10)
            {
                case 10:
                case 9:return "优";
                case 8:return "良";
                case 7:return "中";
                case 6:return "及格";
                default:return "不及格";
            }
        }
    }
}
