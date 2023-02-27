using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_27_DefinitionOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;//声明变量
            arr = new int[6];//创建数组对象
            arr[0] = 1;//为第一个元素赋值1
            arr[1] = 2;//为第二个元素赋值2
            Console.WriteLine("arr[0]=" + arr[0]);//访问数组中的第一个元素
            Console.WriteLine("arr[1]=" + arr[1]);//访问数组中的第二个元素
            Console.WriteLine("arr[3]=" + arr[2]);//访问数组中的第三个元素
            Console.WriteLine("数组的长度是：" + arr.Length);//打印数组长度
            Console.ReadKey();
        }
    }
}
