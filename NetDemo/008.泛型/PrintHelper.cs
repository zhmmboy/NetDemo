using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _008.泛型
{
    /// <summary>
    /// c#中泛型的用法总结
    /// </summary>
    internal class PrintHelper
    {
        /// <summary>
        /// 方法1：int型参数
        /// </summary>
        /// <param name="arrayList"></param>
        public void PrintInt(int number)
        {
            Console.WriteLine($"您输入的信息为：{number}");
        }

        /// <summary>
        /// 方法2：string型参数
        /// </summary>
        /// <param name="arrayList"></param>
        public void PrintString(string str)
        {
            Console.WriteLine($"您输入的信息为：{str}");
        }

        /// <summary>
        /// 方法3：float型参数
        /// </summary>
        /// <param name="arrayList"></param>
        public void PrintFloat(float number)
        {
            Console.WriteLine($"您输入的信息为：{number}");
        }

        /// <summary>
        /// 方法4：采用泛型方法，只需定义一个方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public void Print<T>(T obj)
        {
            Console.WriteLine($"您输入的信息为：{(obj != null ? obj.ToString() : string.Empty)} ");
        }

        /// <summary>
        /// 泛型委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void MyDelegate<T>(T obj);
    }
}
