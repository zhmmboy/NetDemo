using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.简单工厂模式
{
    internal enum DBTypeEnum
    {
        /// <summary>
        /// 数据库类型：SqlServer
        /// </summary>
        SQLSERVER,

        /// <summary>
        /// 数据库类型：MySql
        /// </summary>
        MYSQL,

        /// <summary>
        /// 数据库类型：Oracle
        /// </summary>
        ORACLE
    }
}
