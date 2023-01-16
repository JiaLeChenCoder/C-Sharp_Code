using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_16_ArrayToSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int>listou = new List<int>();
            List<int> listji = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    listou.Add(nums[i]);
                }
                else
                {
                    listji.Add(nums[i]);
                }

            }
            //一种合并方法
            listji.AddRange(listou);
            foreach (int item in listji)
            {
                Console.Write(item + " ");
            }
            //另一种合并方法
            //List<int>listsum = new List<int>();
            //listsum.AddRange(listji);
            //listsum.AddRange(listou);
            //foreach (int item in listsum)
            //    {
            //        Console.Write(item+" " );
            //    }  
        } 
    }
}
