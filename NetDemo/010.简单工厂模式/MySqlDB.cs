using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.简单工厂模式
{
    /// <summary>
    /// MySqlDB实现类
    /// </summary>
    internal class MySqlDB : IDBFactory
    {
        public int Delete()
        {
            Console.WriteLine("这是MySql类的Delete方法。");
            return 0;
        }

        public int Save()
        {
            Console.WriteLine("这是MySql类的Save方法。");
            return 0;
        }
    }
}
