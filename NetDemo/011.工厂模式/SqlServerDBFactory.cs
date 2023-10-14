using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _011.工厂模式
{
    /// <summary>
    /// SqlServerDB实现类
    /// </summary>
    internal class SqlServerDBFactory : IDBFactoryCreator
    {
        public IDBFactory Create()
        {
            return new SqlServerDB();
        }
    }
}