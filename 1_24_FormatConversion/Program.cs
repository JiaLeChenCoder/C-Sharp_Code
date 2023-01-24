using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_24_FormatConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //把"你""我""他""她"变成你|我|他|她，然后把|切割
            string[] names = { "你", "我", "他", "她" };
            string str = string.Join("|", names);
            string[]  strNew = str.Split(new char[]{ '|' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
