using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.工厂模式
{
    /// <summary>
    /// 创建 IDBFactory 实例
    /// </summary>
    interface IDBFactoryCreator
    {
        /// <summary>
        /// 创建 IDBFactory 实例
        /// </summary>
        /// <returns></returns>
        IDBFactory Create();
    }
}
