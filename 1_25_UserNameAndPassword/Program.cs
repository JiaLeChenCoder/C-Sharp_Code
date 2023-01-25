using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_25_UserNameAndPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入用户名和密码，要求用户名等于陈家乐，密码等于123123，只要用户名或密码错误就重新输入，最多输入3次
            string UserName = "";
            string UserPwd= "";
            Console.WriteLine("请输入用户名");
            UserName = Console.ReadLine();
            bool b = false;
            while (true)
            {
                if (UserName == "陈家乐")
                {
                    Console.WriteLine("请输入密码");
                    while (true)
                    {
                        UserPwd = Console.ReadLine();
                        if (UserPwd == "1231232")
                        {
                            Console.WriteLine("登录成功");
                             b = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("密码错误");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("用户名不正确,请输入用户名");
                    UserName = Console.ReadLine();
                }
                if(b==true)
                  {
                        break;
                  }
            }
            Console.ReadKey();

        }
    }
}
