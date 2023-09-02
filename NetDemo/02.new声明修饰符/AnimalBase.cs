//这是 AnimalBase.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.new声明修饰符
{
    internal class AnimalBase
    {
        public AnimalBase()
        {
            this.AnimalName = "我是AnimalBase。";
        }

        /// <summary>
        /// 动物名称
        /// ?表示该变量可为Null
        /// </summary>
        public virtual string? AnimalName { get; set; }
        public virtual void Call()
        {
            Console.WriteLine("我是AnimalBase的Call方法。");
        }
    }
}
