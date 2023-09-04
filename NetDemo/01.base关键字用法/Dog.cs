//这是 Dog.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.base关键字用法
{
    internal class Dog : AnimalBase
    {
        public string dogName {  get; set; }

        /// <summary>
        /// 调用基类无参的构造函数，这里的:base()可以省略不写
        /// </summary>
        public Dog():base()
        {
        }

        /// <summary>
        /// 调用基类有参的构造函数
        /// </summary>
        /// <param name="animalName"></param>
        public Dog(string animalName) : base(animalName)
        {
        }

        public override void GetName()
        {
            base.AnimalName = dogName;
            //base.AnimalName2 = dogName;
            //base.AnimalName3 = dogName;
            //base.AnimalName4 = dogName;
            //base.AnimalName5 = dogName;
            //base.AnimalName6 = dogName;
            base.GetName();
            Console.WriteLine($"我是Dog的GetName方法。");
        }
    }
}
