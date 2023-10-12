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
    internal class MySqlDB : AbstractDBFactory
    {
        public override int Delete()
        {
            Console.WriteLine("这是MySql类的Delete方法。");
            return 0;
        }

        public override int Save()
        {
            Console.WriteLine("这是MySql类的Save方法。");
            return 0;
        }
    }
}
