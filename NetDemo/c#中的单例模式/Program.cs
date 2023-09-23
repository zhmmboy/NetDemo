// 这是 Program.cs 类

//1.单线程单例模式
using c_中的单例模式;

var logHelper1 = LogHepler1.Instance;
for (var i = 0; i < 1000; i++)
{
    var logHelper2 = LogHepler1.Instance;
    if (logHelper1 != logHelper2)
    {
        Console.WriteLine("实例不相等。");
        break;
    }
}