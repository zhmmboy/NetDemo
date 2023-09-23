//这是 Calculate.cs 类
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _008.泛型
{
    /// <summary>
    /// c#中泛型的用法总结
    /// </summary>
    internal class Calculate
    {
        ///// <summary>
        ///// 方法1：返回两个数字相加
        ///// </summary>
        ///// <param name="arrayList"></param>
        //public decimal Add(decimal numA, decimal numB)
        //{
        //    return numA + numB;
        //}

        ///// <summary>
        ///// 方法2：返回两个数字相加
        ///// </summary>
        ///// <param name="arrayList"></param>
        //public decimal Add(string strA, string strB)
        //{
        //    return Convert.ToDecimal(strA) + Convert.ToDecimal(strB);
        //}

        /// <summary>
        /// 方法3：返回两个数字相加,用基类object代替具体的类型
        /// </summary>
        /// <param name="objA"></param>
        /// <param name="objB"></param>
        /// <returns></returns>
        public decimal Add(object objA, object objB)
        {
            File.AppendAllText($"{System.AppDomain.CurrentDomain.BaseDirectory}\\log.txt", $"\n\n传入的参数1：{objA.ToString()}；参数2：{objB.ToString()}");
            var total =  Convert.ToDecimal(objA) + Convert.ToDecimal(objB);
            File.AppendAllText($"{System.AppDomain.CurrentDomain.BaseDirectory}\\log.txt", $"\n返回结果为：{total.ToString()}");
            return total;
        }

        public T Add<T>(T t1,T t2)
        {
            return t1;
        }
    }
}
