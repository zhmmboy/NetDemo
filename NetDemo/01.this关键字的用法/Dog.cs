//这是 Dog.cs 类
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.this关键字的用法
{
    internal class Dog
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Dog() { }

        public Dog(AnimalBase animalBase)
        {
            Console.WriteLine("AnimalBase.AnimalID：" + animalBase.AnimalID);
            Console.WriteLine("AnimalBase.AnimalName：" + animalBase.AnimalName);
        }

        public string this[int index]
        {
            get
            {
                return (string)this[index];
            }
            set
            {
                this[index] = value;
            }
        }
    }
}
