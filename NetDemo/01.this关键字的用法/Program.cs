//这是 Program.cs 类

using _01.this关键字的用法;

//AnimalBase animalBase = new AnimalBase("001", "我是汪汪", 100);
//animalBase.GetName();

//4）作为索引器
//例如，假设有一个类 TempRecord，它表示 24 小时的周期内在 10 个不同时间点所记录的温度（单位为华氏度）。 
//此类包含一个 float[] 类型的数组 temps，用于存储温度值。 通过在此类中实现索引器，
//客户端可采用 float temp = tempRecord[4] 的形式（而非 float temp = tempRecord.temps[4]）访问 TempRecord 实例中的温度。

var temp = new TempRecord();
temp[0] = 35;
temp[3] = 38;

Console.WriteLine("temp[0] is :" + temp[0]);
Console.WriteLine("temp[3] is :" + temp[3]);
