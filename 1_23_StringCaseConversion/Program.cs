using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_23_StringCaseConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //大小写转化练习
            Console.WriteLine("请输入你喜欢的课程");
            string LessonOne = Console.ReadLine();
            string LessonTwo = Console.ReadLine();
            //LessonOne = LessonOne.ToLower();//转为小写
            LessonOne = LessonOne.ToUpper();//转为大写
            //LessonTwo = LessonTwo.ToLower();//转为小写
            LessonTwo = LessonTwo.ToUpper();//转为大写
            if (LessonTwo == LessonOne)
            {
                Console.WriteLine("喜欢的课程相同");
            }
            else
            {
                Console.WriteLine("喜欢的课程不相同");
            }
            Console.ReadKey();
        }
    }
}
