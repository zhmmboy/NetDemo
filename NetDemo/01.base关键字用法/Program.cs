//这是 Program.cs 类
using _01.base关键字用法;

Console.WriteLine("派生类调用基类无参构造函数。");
Dog dog = new Dog();

Console.WriteLine("\n派生类调用基类有参构造函数。");
Dog dog2 = new Dog("汪汪");

Console.WriteLine("\n派生类调用基类成员变量/方法。");
dog.dogName = "我是儿子-汪仔";
dog.GetName();



