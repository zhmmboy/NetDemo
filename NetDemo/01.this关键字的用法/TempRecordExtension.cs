//这是 TempRecordExtension.cs 类

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.this关键字的用法
{
    /// <summary>
    /// 
    /// </summary>
    static internal class TempRecordExtension
    {
        public static void Print(this TempRecord tempRecord)
        {
            Console.WriteLine("这是TempRecord扩展类的一个无参数的扩展方法。");
        }

        public static void Print2(this TempRecord tempRecord, float temperature)
        {
            Console.WriteLine($"这是TempRecord扩展类的一个有参数的扩展方法。传入参数：{temperature}");
        }
    }
}
