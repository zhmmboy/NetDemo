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
    public static class Class2
    {
        public int ID { get; set; }
        public string GetID()
        {
            return string.Empty;
        }
    }
}
