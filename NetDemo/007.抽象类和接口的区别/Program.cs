//这是 Program.cs 类

using _007.抽象类和接口的区别;

//1.测试抽象类中的索引器
Dog dog = new Dog();
Console.WriteLine(dog[0]);
Console.WriteLine(dog[1]);
Console.WriteLine(dog[2]);

dog[0] = "红色001";
dog[1] = "红色002"; 
dog[2] = "红色003";
Console.WriteLine(dog[0]);
Console.WriteLine(dog[1]);
Console.WriteLine(dog[2]);

//抽象类不能实例化（也就是不能new出来）
//AbstractAnimalBase  abstractAnimal = new AbstractAnimalBase();

//这是接口类不能实例化（也就是不能new出来）
//IAnimalBase ianimalBase= new IAnimalBase();


