//这是 Program.cs 类
using _02.new声明修饰符;

AnimalBase animalBase = new Dog();
Console.WriteLine($"AnimalName:{animalBase.AnimalName}");
animalBase.Call();

Console.WriteLine("\n");
Dog dog = new Dog();
Console.WriteLine($"AnimalName:{dog.AnimalName}");
dog.Call();
