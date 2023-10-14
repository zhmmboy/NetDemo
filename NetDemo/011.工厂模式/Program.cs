//c#中工厂模式演示

using _011.工厂模式;

Console.WriteLine("这是《_011.工厂模式》演示");
Console.WriteLine("\n");

//调用SqlServer数据库实例
IDBFactory sqlServerDBFactory = new SqlServerDBFactory().Create();
sqlServerDBFactory.Save();
sqlServerDBFactory.Delete();

Console.WriteLine("\n");
//调用MySql数据库实例
IDBFactory mySqlDBFactory = new MySqlDBFactory().Create();
mySqlDBFactory.Save();
mySqlDBFactory.Delete();

Console.WriteLine("\n");
//调用Oracel数据库实例
IDBFactory oracelDBFactory = new OracleDBFactory().Create();
oracelDBFactory.Save();
oracelDBFactory.Delete();