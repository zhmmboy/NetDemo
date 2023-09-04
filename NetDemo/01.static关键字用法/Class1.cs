using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.static关键字用法
{
    /// <summary>
    /// 非静态类可以包含静态成员变量/静态方法
    /// </summary>
    public class Class1
    {
        public static int ID { get; set; }
        public static string GetID()
        {
            return string.Empty;
        }
    }
}
