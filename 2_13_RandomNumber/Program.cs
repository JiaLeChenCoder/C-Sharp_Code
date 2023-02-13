using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13_RandomNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //写一个长度为10的集合，要求在里面随机放10个数字（0-9），要求里面的数字不能重复
            ArrayList List = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rnumber = r.Next(0, 10);
                if (!List.Contains(rnumber))
                {
                    List.Add(rnumber);
                }
                else//集合中有这个随机数
                {
                    i--;//一旦产生重复的随机数，这次的循环就不算数
                }
            }
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.ReadKey();
        }
    }
}
