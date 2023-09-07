//这是 Program.cs 类

using _01.this关键字的用法;

//AnimalBase animalBase = new AnimalBase("001", "我是汪汪", 100);
//animalBase.GetName();

//4.1）作为索引器
//例如，假设有一个类 TempRecord，它表示 24 小时的周期内在 10 个不同时间点所记录的温度（单位为华氏度）。 
//此类包含一个 float[] 类型的数组 temps，用于存储温度值。 通过在此类中实现索引器，
//客户端可采用 float temp = tempRecord[4] 的形式（而非 float temp = tempRecord.temps[4]）访问 TempRecord 实例中的温度。

//var temp = new TempRecord();
//temp[0] = 35;
//temp[3] = 38;

//Console.WriteLine("temp[0] is :" + temp[0]);
//Console.WriteLine("temp[3] is :" + temp[3]);

//根据学生姓名和课程编号查询成绩
Student student = new Student();

////4.2.索引器多参数测试
//student["小米", 1] = 100;
//student["小果", 2] = 88;
//student["小米", 5] = 90;
//student["小粒", 5] = 97;

//int stuScore = student["小米", 1];
//int stuScore2 = student["小果", 2];
//int stuScore3 = student["小粒", 6];//找不到该索引，返回0

//Console.WriteLine($"小米成绩：{stuScore}");
//Console.WriteLine($"小果成绩：{stuScore2}");
//Console.WriteLine($"小粒成绩：{stuScore3}");


////4.2.索引器重载测试：根据学生姓名查询学习成绩列表
//List<StuScores> list = student["小米"];
//foreach (StuScores s in list)
//{
//    Console.WriteLine($"课程编号：{s.CourseID}，成绩：{s.CourseScore}");
//}


//5.扩展方法测试
TempRecord tempRecord = new TempRecord();
tempRecord.Print();
tempRecord.Print2(38.6F);
