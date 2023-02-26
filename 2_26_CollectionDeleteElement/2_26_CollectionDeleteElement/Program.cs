using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2_26_CollectionDeleteElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            //将新建的集合对象添加到arr的末尾
            arr.AddRange(new ArrayList() { "张三", "李四", "王五" });
            arr.Remove("张三");//从集合中删除指定元素的第一个匹配项
            arr.RemoveAt(1);//删除指定索引位置的元素
           // arr.Clear();//删除所有的元素
            A(arr);//遍历元素
            //Console.WriteLine("arr的实际长度为{0}", arr.Count);
            Console.WriteLine("arr的实际长度为：" + arr.Count);
            Console.ReadKey();

        }
        //遍历集合
        static void A(ArrayList arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
