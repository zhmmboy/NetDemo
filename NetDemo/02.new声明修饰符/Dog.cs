//这是 Dog.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.new声明修饰符
{
    internal class Dog : AnimalBase
    {
        public Dog()
        {
            this.AnimalName = "我是Dog。";
        }

        /// <summary>
        /// 动物名称
        /// ?表示该变量可为Null
        /// </summary>
        public override string? AnimalName { get; set; }
        public override void Call()
        {
            Console.WriteLine("我是Dog的Call方法。");
        }
    }
}
