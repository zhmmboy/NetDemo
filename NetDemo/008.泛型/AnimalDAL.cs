using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.泛型
{
    internal class AnimalDAL<T> : IAnimalDAL<T> where T : class
    {
        public List<T> Query(T model)
        {
            Console.WriteLine("我实现了泛型接口中的方法，我查询了一些数据。");
            return new List<T>();
        }

        public void Save(T model)
        {
            Console.WriteLine("我实现了泛型接口的方法，成功保存了一条数据。");
        }

    }
}
