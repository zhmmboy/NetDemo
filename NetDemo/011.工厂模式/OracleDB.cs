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
    internal class OracleDB : AbstractDBFactory
    {
        public override int Delete()
        {
            Console.WriteLine("这是OracleDB类的Delete方法。");
            return 0;
        }

        public override int Save()
        {
            Console.WriteLine("这是OracleDB类的Save方法。");
            return 0;
        }
    }
}
