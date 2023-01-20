using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_20_WordReverseOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] StrNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < StrNew.Length / 2; i++)
            {
                string temp = StrNew[i];
                StrNew[i] = StrNew[StrNew.Length - 1-i];
                StrNew[StrNew.Length - 1 - i] = temp;
            }
            str = string.Join("  ", StrNew);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
