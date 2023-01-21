using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_21_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //从email中提取处域名和用户名。
            string email = "3257853364@qq.com";
            int index = email.IndexOf('@');
            string username = email.Substring(0, index);
            string yuming = email.Substring(index + 1);
            Console.WriteLine(yuming);
            Console.WriteLine(username);
            Console.ReadKey();
        }
    }
}
