using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_19_StringReverseOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接受用户输入的字符串，将其中的字符与输入相反的顺序输出。
            string str = Console.ReadLine();
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length / 2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length-1-i];
                chs[chs.Length - 1-i] = temp;
            }
            str = new string(chs);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
