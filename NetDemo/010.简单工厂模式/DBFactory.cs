using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.简单工厂模式
{
	/// <summary>
	/// DB工厂类
	/// </summary>
	internal class DBFactory
    {
        private DBFactory() { }

        /// <summary>
        /// 获取数据库操作实例
        /// </summary>
        /// <param name="dBTypeEnum"></param>
        /// <returns></returns>
        public static IDBFactory GetInstance(DBTypeEnum dBTypeEnum)
        {
            IDBFactory _instance = null;
            switch (dBTypeEnum)
            {
                case DBTypeEnum.SQLSERVER: _instance = new SqlServerDB(); break;
                case DBTypeEnum.MYSQL: _instance = new MySqlDB(); break;
                case DBTypeEnum.ORACLE: _instance = new OracleDB(); break;
            }
            return _instance;
        }
    }
}
