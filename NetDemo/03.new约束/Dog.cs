//这是 Dog.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.new约束
{
    //如果是抽象类，则编译不通过
    //internal abstract class Dog
    internal class Dog
    {
        /// <summary>
        /// 如果构造函数存在参数，则编译不通过
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Name"></param>
        //public Dog(int ID, string Name)
        //{
        //}

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
