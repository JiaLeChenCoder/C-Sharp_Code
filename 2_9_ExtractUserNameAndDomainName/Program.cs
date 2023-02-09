using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9_ExtractUserNameAndDomainName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String email = "333222569@qq.com";
            int index = email.IndexOf('@');
            string UserName = email.Substring(0, index);
            string DomainName = email.Substring(index + 1);
            Console.WriteLine("用户名是{0}，域名是{1}", UserName, DomainName);
            Console.ReadKey();
        }
    }
}
