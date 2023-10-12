using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.泛型
{
    internal interface IAnimalDAL<T> where T : class
    {
        /// <summary>
        /// 保存数据方法
        /// </summary>
        void Save(T model);

        /// <summary>
        /// 查询数据方法
        /// </summary>
        List<T> Query(T model);
    }
}
