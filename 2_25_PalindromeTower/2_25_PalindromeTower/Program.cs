using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_25_PalindromeTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n * 2; j++)
                {
                    if (i >= n - j && i >= j - n)
                    {
                        Console.Write("{0}", j > n ? (i + 1) + n - j : (i + 1) + j - n);
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();


        }
    }
}
