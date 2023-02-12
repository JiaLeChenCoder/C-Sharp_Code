using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_SplitMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //分割字符串，返回字符串类型的数组
            string s = "2018-08-08";
            string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            Console.ReadKey();
        }
    }
}
