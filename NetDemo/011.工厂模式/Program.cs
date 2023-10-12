//c#中简单工厂模式演示

using _011.工厂模式;

//调用SqlServer数据库实例
AbstractDBFactory sqlServerDBFactory = new SqlServerDB();
sqlServerDBFactory.Save();
sqlServerDBFactory.Delete();

Console.WriteLine("\n");
//调用MySql数据库实例
AbstractDBFactory mySqlDBFactory = new MySqlDB();
mySqlDBFactory.Save();
mySqlDBFactory.Delete();

Console.WriteLine("\n");
//调用Oracel数据库实例
AbstractDBFactory oracelDBFactory = new OracleDB();
oracelDBFactory.Save();
oracelDBFactory.Delete();