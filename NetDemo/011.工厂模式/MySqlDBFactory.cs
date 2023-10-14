using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.工厂模式
{
    /// <summary>
    /// MySqlDB实现类
    /// </summary>
    internal class MySqlDBFactory : IDBFactoryCreator
    {
        public IDBFactory Create()
        {
            return new MySqlDB();
        }
    }
}
