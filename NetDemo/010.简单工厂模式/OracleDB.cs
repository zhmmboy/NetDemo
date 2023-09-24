using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.简单工厂模式
{
    internal class OracleDB : IDBFactory
    {
        public int Delete()
        {
            Console.WriteLine("这是OracleDB类的Delete方法。");
            return 0;
        }

        public int Save()
        {
            Console.WriteLine("这是OracleDB类的Save方法。");
            return 0;
        }
    }
}
