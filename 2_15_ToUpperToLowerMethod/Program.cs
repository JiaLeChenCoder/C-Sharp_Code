using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_15_ToUpperToLowerMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("张三，请输入你喜欢的课程");
            string LessonOne = Console.ReadLine();
            Console.WriteLine("李四，请输入你喜欢的课程");
            string LessonTwo = Console.ReadLine();
            LessonOne = LessonOne.ToLower();//小写
            //LessonOne = LessonOne.ToUpper();//大写
            LessonTwo = LessonTwo.ToLower();//小写
            //LessonTwo = LessonTwo.ToUpper();//大写
            if (LessonTwo == LessonOne)
            {
                Console.WriteLine("喜欢的课程一样");
            }
            else
            {
                Console.WriteLine("喜欢的课程不一样");
            }
            Console.ReadKey();

        }
    }
}
