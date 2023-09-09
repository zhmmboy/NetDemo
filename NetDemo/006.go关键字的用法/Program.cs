using _006.go关键字的用法;

Login login = new Login();
var msg = login.ValidateLogin("admin", "123456");
Console.WriteLine($"验证结果：{msg}");