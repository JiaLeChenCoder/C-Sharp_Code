using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_18_ArrayMaxMinSumAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
               sum+=nums[i];
            }
            Console.WriteLine("数组的值是:");
            foreach (var i in nums) 
            {
                Console.Write("{0}",i);
            }
            Console.WriteLine("\n数组中的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, sum / nums.Length);
            Console.ReadKey();
        }
    }
}
