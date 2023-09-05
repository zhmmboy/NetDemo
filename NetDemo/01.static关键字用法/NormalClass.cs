//这是 NormalClass.cs 类

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.static关键字用法
{
    /// <summary>
    /// 非静态类可以包含静态成员变量/静态方法
    /// </summary>
    public class NormalClass
    {
        static NormalClass() { Console.WriteLine("非静态类中的静态构造函数被执行了。"); }

        public NormalClass() { Console.WriteLine("非静态类中的构造函数被执行了。"); }


        public int NormalClassID { get; set; }
        public static int ID { get; set; }
        public static string GetID()
        {
            return string.Empty;
        }
        public static string GetName()
        {   
            return string.Empty;
        }
    }
}
