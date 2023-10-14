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
    internal class SqlServerDB : IDBFactory
    {
        public int Delete()
        {
            Console.WriteLine("这是SqlServerDB类的Delete方法。");
            return 0;
        }

        public int Save()
        {
            Console.WriteLine("这是SqlServerDB类的Save方法。");
            return 0;
        }
    }
}
