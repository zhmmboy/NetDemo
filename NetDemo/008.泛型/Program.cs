// 这是 Program.cs 类

using _008.泛型;

decimal num = new Calculate().Add(1, 2);
Console.WriteLine($"方法返回值：{num}");

num = new Calculate().Add(100, 200);
Console.WriteLine($"方法返回值：{num}");

num = new Calculate().Add("abc", 2);
Console.WriteLine($"方法返回值：{num}");