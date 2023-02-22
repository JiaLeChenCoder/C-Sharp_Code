using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_22_CopyArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将数组A中的元素复制到数组B中
            int[] A = { 1, 2, 3,4,5,6 };
            int[] B=new int[10];
            for (int i = 0; i < A.Length; i++)
            {
                B[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }
            Console.ReadKey();
        }
    }
}
