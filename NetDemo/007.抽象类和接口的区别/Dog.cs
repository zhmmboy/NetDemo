//这是 Dog.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007.抽象类和接口的区别
{
    /// <summary>
    /// 这是子类
    /// </summary>
    internal class Dog : AbstractAnimalBase, IAnimalBase
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public Dog() { }

        /// <summary>
        /// 实现抽象类方法，需要使用override声明关键字
        /// </summary>
        public override void GetName()
        {

        }

        #region  必须实现接口的全部成员
        string[] IAnimalBase.AnimalColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        event IAnimalBase.MyDelegate IAnimalBase.myEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public int Eat()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
