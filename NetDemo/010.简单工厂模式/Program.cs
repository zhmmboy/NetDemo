//c#中简单工厂模式演示

using _010.简单工厂模式;

//调用SqlServer数据库实例
IDBFactory sqlServerDBFactory = DBFactory.GetInstance(DBTypeEnum.SQLSERVER);
sqlServerDBFactory.Save();
sqlServerDBFactory.Delete();

Console.WriteLine("\n");
//调用MySql数据库实例
IDBFactory mySqlDBFactory = DBFactory.GetInstance(DBTypeEnum.MYSQL);
mySqlDBFactory.Save();
mySqlDBFactory.Delete();

Console.WriteLine("\n");
//调用Oracel数据库实例
IDBFactory oracelDBFactory = DBFactory.GetInstance(DBTypeEnum.ORACLE);
oracelDBFactory.Save();
oracelDBFactory.Delete();