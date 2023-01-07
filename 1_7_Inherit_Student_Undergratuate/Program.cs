using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_Inherit_Student_Undergratuate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三", 19);
            Undergraduate s1 = new Undergraduate("李四", 20, "本科");
            s.Show();
            s1.Show();
            Console.ReadKey();
        }
    }
}
