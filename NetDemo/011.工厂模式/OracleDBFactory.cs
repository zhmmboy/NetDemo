using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.工厂模式
{
    /// <summary>
    /// OracleDB实现类
    /// </summary>
    internal class OracleDBFactory : IDBFactoryCreator
        {public IDBFactory Create()
        {
            return new OracleDB();
        }
    }
}
