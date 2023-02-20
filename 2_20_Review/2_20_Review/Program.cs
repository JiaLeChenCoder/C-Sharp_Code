using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_20_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("这是我的第一个C#程序");
            //Console.ReadKey();
            //Console.WriteLine("请输入一个数");
            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 1)
            //{
            //    Console.WriteLine("你输入的是奇数");
            //}
            //else
            //{
            //    Console.WriteLine("你输入的是偶数");
            //}
            //Console.ReadKey();
            //Console.WriteLine("结果如下");
            //int num = 0;
            //for (int i = 1; i <= 99; i+=2)
            //{
            //    num += i; 
            //}
            //Console.WriteLine("结果是{0}",num);
            //Console.ReadKey();
            try
            {
                int num1 = 10;
                int num2 = 0;
                int num3 = num1 / num2;
                Console.WriteLine("num3=" + num3);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("已处理异常信息：" + e.Message);
                return;
            }
            catch (SystemException)
            {
                Console.WriteLine("已处理系统" +
                    "异常");
                return;
            }
            catch {
                Console.WriteLine("已处理异常");
                return;
            }
            finally {
                Console.WriteLine("finally块被执行");
                Console.ReadKey();
            }
        }
    }
}
