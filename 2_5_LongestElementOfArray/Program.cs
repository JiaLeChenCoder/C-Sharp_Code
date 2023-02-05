using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_LongestElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] names = { "中国", "美国", "澳大利亚", "俄罗斯" };
            string max = GetLongest(names);
            Console.WriteLine(max);
            Console.ReadKey();
        }
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
    }
}
