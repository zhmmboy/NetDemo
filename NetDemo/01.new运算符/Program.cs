//这是 Program.cs 类

using _01.new运算符;

Console.WriteLine("1）new 运算符：调用构造函数");
AnimalBase animalBase = new AnimalBase();

Console.WriteLine("\n1）new 运算符：继承了基类，调用了基类和自己的构造函数");
AnimalBase animalBase1 = new Dog();
Dog dog = new Dog();
