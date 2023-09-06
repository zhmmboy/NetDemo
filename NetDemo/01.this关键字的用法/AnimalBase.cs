//这是 AnimalBase.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.this关键字的用法
{
    internal class AnimalBase
    {
        public string? AnimalID { get;set; }
        public string? AnimalName { get;set; }

        public AnimalBase(string AnimalID, string AnimalName)
        {
            //当类成员变量名称和传入参数名称相同时，成员变量名称前须用this.的形式，区分成员变量和传入参数
            this.AnimalID = AnimalID;
            this.AnimalName = AnimalName;
            Console.WriteLine("我是两个参数的构造函数。");
        }

        /// <summary>
        /// 这是可以使用 this(AnimalID, AnimalName) 的形式调用上面第一个构造函数
        /// </summary>
        /// <param name="AnimalID"></param>
        /// <param name="AnimalName"></param>
        /// <param name="AnimalCount"></param>
        public AnimalBase(string AnimalID, string AnimalName, int AnimalCount) : this(AnimalID, AnimalName)
        {
            Console.WriteLine("我是三个参数的构造函数。");
        }

        /// <summary>
        /// 把当前对象作为参数传递
        /// </summary>
        public void GetName()
        {
            Dog dog = new Dog(this);
        }
    }
}
