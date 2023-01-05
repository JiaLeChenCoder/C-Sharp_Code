using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _1_5_Fibonacci_Gregory_Stratum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //显示Fibonacci数列：1，1，2，3，5，8，···。当值大于10000时停止显示。并且每行显示5项。
            //int c;
            //for (int i = 1; ; i++)
            //{
            //    c = Fibonacci(i);
            //    if (c >= 10000)
            //        break;
            //    Console.Write("{0}\t", c);
            //    if (i % 5 == 0)
            //        Console.Write(Environment.NewLine);
            //}
            //Console.ReadKey();
            //int Fibonacci(int n)
            //{
            //    if (n == 1 || n == 2)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return Fibonacci(n - 1) + Fibonacci(n - 2);
            //    }
            //}

            //格里高利公式pi的近似值，直到最后一项的绝对值小于0.000001为止。（pi/4=1-1/3+1/5-1/7+1/9-···）
            //float s = 1, i, pi, t = 1;
            //for (i = 3; 1.0 / i >= 1.0 / 1000000; i += 2)
            //{
            //    s -= 1 / i * t;
            //    t = -t;
            //}
            //pi = s * 4;
            //Console.WriteLine("{0}", pi);
            //Console.ReadKey();
            // 求n的阶层
            //第一种方法
            //int i = 0;
            //int value = 1;
            //Console.WriteLine("求的阶层数是？");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i < n + 1; i++)
            //{
            //    value *= i;
            //}
            //Console.WriteLine("结果是{0}", value);
            //Console.ReadKey();

            //第二种方法
            //Console.WriteLine("求的阶层数是？");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int value = 1;
            //Program f = new Program();
            //value = f.B(n);
            //Console.WriteLine("结果是：{0}", value);
            //Console.ReadKey();

            //第三种方法
            //Console.WriteLine("求的阶层数是？");
            //int t = Convert.ToInt32(Console.ReadLine());
            //int value;
            //Program f = new Program();
            //value = f.A(t);
            //Console.WriteLine("结果是：{0}", value);
            //Console.ReadKey();
        }
        //第二种方法中的方法A
        //public int A(int n)
        //{
        //    int r = 1;
        //    while (n != 1)
        //    {
        //        r = r * n;
        //        n = n - 1;
        //    }
        //    return r;
        //}

        //第三种方法中的方法B
        //public int B(int n)
        //{
        //    if (n == 1)
        //        return 1;
        //    else
        //        return n * B(n - 1);
        //}
    }
}
