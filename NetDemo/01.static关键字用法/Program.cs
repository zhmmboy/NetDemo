//这是 Program.cs 类

using _01.static关键字用法;

//自动调用静态构造函数
StaticClass.ID= 200;

//自动优先调用静态构造函数，无参构造函数
Console.WriteLine("\n");
NormalClass normalClass = new NormalClass();