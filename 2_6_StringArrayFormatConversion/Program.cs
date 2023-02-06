using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_StringArrayFormatConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将字符串数组{“中国”，“美国”，“俄罗斯”}转化成{中国|美国|俄罗斯}，用方法实现。
            string[]names = { "中国", "美国", "俄罗斯" };
            string str=processstring(names);
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static string processstring(string[] names)
        {
            string str = null;
            for (int i = 0; i <names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            return str + names[names.Length - 1];
        }
    }
}
