using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_17_Second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //实现90000秒是几天几小时
            int seconds = 90000;
            int days = seconds / 86400;//求天数，86400秒=1天
            int secs = seconds % 86400;//求得求完天数的秒。
            int hours = secs / 3600;//求得小时数（3600秒=1小时）
            secs = secs % 3600;//求得小时后的秒数
            int mins = secs / 60;//求得分钟数
            secs = secs % 60;//最后秒数
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, mins, secs);
            Console.ReadKey();

        }
    }
}
