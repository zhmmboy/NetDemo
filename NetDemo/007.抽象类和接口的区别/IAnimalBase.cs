//这是 IAnimalBase.cs 类

namespace _007.抽象类和接口的区别
{
    /// <summary>
    /// 这是接口类
    /// </summary>
    interface IAnimalBase
    {
        //定义成员变量
        public string[] AnimalColor { get; set; }

        //定义委托，事件
        delegate int MyDelegate();
        event MyDelegate myEvent;

        //定义索引器
        string this[int index]
        {
            get; set;
        }

        //定义成员方法
        int Eat();
    }
}