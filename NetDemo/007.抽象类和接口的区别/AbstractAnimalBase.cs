//这是 AbstractAnimalBase.cs 类

namespace _007.抽象类和接口的区别
{
    /// <summary>
    /// 这是抽象类
    /// </summary>
    internal abstract class AbstractAnimalBase
    {
        //定义普通成员属性，数组
        public string? AnimalID { get; set; }
        public string? AnimalName { get; set; }
        public string[] AnimalColor = new string[] { "红色", "橘色", "黄色" };

        /// <summary>
        /// 定义非抽象方法，可以有具体的实现代码
        /// </summary>
        public int GetID()
        {
            Console.WriteLine("这是抽象类中声明的非抽象方法。");
            return 100;
        }

        /// <summary>
        /// 定义抽象方法，不能有具体的实现代码
        /// </summary>
        public abstract void GetName();

        /// <summary>
        ///定义事件，委托
        /// </summary>
        public delegate int MyDelegate();
        public MyDelegate myDelegate;
        public event MyDelegate myEvent;

        public AbstractAnimalBase()
        {
            myDelegate = GetID;
            var ID = myDelegate.Invoke();
            Console.WriteLine($"这是调用委托获取 ID：{ID}");
        }

        /// <summary>
        /// 定义索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get { return AnimalColor[index]; }
            set { AnimalColor[index] = value; }
        }
    }
}
