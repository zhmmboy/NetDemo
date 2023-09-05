//这是 StaticClass.cs 类

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.static关键字用法
{
    /// <summary>
    /// 静态类中不能声明静态成员变量/静态方法
    /// </summary>
    public static class StaticClass
    {
        ///// <summary>
        ///// 以下属于实例成员，必须new类的实例，通过实例对象访问 
        ///// </summary>
        //public int NID = 0;
        //public int NName { get; set; }
        //public string GetNName() { return string.Empty; }

        static StaticClass()
        {
            Console.WriteLine("静态类中的静态构造函数被执行了。");
        }

        public static int ID;
        public static string GetID()
        {
            return string.Empty;
        }
    }
}
