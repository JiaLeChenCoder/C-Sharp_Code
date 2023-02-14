using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_14_StringAssignmentToCharacterArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            Console.WriteLine("请输入一个字符串");
            string input = Console.ReadLine();
            char[] chs = new char[input.Length];
            int i = 0;
            foreach (var item in input)
            {
                chs[i] = item;
                i++;
            }
            foreach (var item in chs)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
