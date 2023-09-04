//这是 AnimalBase.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.base关键字用法
{
    internal class AnimalBase
    {
        public string? AnimalName { get;set; }
        //protected string? AnimalName2 { get;set; }
        //internal string? AnimalName3 { get;set; }
        //protected internal string? AnimalName4 { get;set; }
        //private string? AnimalName5 { get;set; }
        //private protected string? AnimalName6 { get;set; }

        public AnimalBase()
        {
            Console.WriteLine("我是AnimalBase的无参构造函数。");
        }

        public AnimalBase(string animalName)
        {
            Console.WriteLine($"我是AnimalBase的有参构造函数。我的新名字叫：{animalName}");
        }

        public virtual void GetName()
        {
            Console.WriteLine($"我是AnimalBase的GetName方法。我的新名字叫：{AnimalName}");
        }
    }
}
