using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_ProcessClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process[] pros = Process.GetProcesses();
            foreach (var item in pros) 
            {
                Console.WriteLine(item);//正在运行的所有进程
            }
            //通过进程打开一些应用程序
            Process.Start("calc");//计算器
            Process.Start("mspaint");//画图工具
            Process.Start("notepad");//记事本
            Process.Start("iexplore", "http://www.baidu.com");//百度
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\陈家乐\Desktop\病毒记录.txt");
            //创建对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}
