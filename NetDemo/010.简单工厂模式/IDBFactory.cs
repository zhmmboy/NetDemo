using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.简单工厂模式
{
    interface IDBFactory
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        int Save();

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        int Delete();
    }
}
