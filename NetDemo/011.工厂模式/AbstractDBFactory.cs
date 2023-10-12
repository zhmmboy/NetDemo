using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.工厂模式
{
    /// <summary>
    /// 数据库操作接口类
    /// </summary>
    abstract class AbstractDBFactory
    {
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        public abstract int Save();

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        public abstract int Delete();
    }
}
