//这是 AnimalBase.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.new约束
{
    internal class AnimalBase<T> where T : new()
    {
        public AnimalBase()
        {

        }

        /// <summary>
        /// 查询一条记录返回
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public T GetById(int? ID)
        {
            Console.WriteLine("成功的查询了一条记录");
            return new T();
        }

        /// <summary>
        /// 新增一条记录后返回
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public T Save(T model)
        {
            Console.WriteLine("成功的新增了一条记录");
            return model;
        }
    }
}
