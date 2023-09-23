using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace c_中的单例模式
{
    #region ===========================================1）饿汉式===========================================
    /// <summary>
    /// 优点：实例在类加载的时候就已经创建好了，并且线程安全。
    /// 缺点：实例在类加载的时候就已经创建好了，如果不使用造成资源浪费。
    /// </summary>
    public sealed class LogHepler1
    {
        //私有的构造函数，防止用new关键字声明对象
        private LogHepler1() { }
        private static LogHepler1 logHepler = new LogHepler1();
        public static LogHepler1 Instance
        {
            get
            {
                return logHepler;
            }
        }
    }
    #endregion

    #region ===========================================2）懒汉式===========================================
    /// <summary>
    /// 优点：实例在需要的时候才会创建，不会造成内存浪费。
    /// 缺点：多个线程同时访问获取实例时，可能会创建多个实例，这不是线程安全的。
    /// </summary>
    public sealed class LogHepler2
    {
        //私有的构造函数，防止用new关键字声明对象
        private LogHepler2() { }
        private static LogHepler2 dbHepler = null;
        public static LogHepler2 Instance
        {
            get
            {
                if (dbHepler == null)
                {
                    dbHepler = new LogHepler2();
                }
                return dbHepler;
            }
        }
    }
    #endregion

    #region ===========================================3）双重检查锁定（Double-Checked Locking）===========================================
    /// <summary>
    /// 优点：可以保证线程安全，并且实例在需要时才会创建，不会造成内存浪费。
    /// 缺点：由于使用了锁，会引入额外的性能开销。
    /// </summary>
    public sealed class LogHepler3
    {
        //私有的构造函数，防止用new关键字声明对象
        private LogHepler3() { }
        //加锁因子
        private readonly static object obj3 = new object();
        private static LogHepler3 dbHepler3 = null;
        public static LogHepler3 Instance3
        {
            get
            {
                if (dbHepler3 == null)
                {
                    lock (obj3)
                    {
                        if (dbHepler3 == null)
                        {
                            dbHepler3 = new LogHepler3();
                        }
                    }
                }
                return dbHepler3;
            }
        }
    }
    #endregion

    #region ===========================================4）静态构造函数===========================================
    /// <summary>
    /// 优点：不是提前创建对象，节省资源，线程安全。
    /// 缺点：完全懒惰的，在执行Instance调用时，才会执行嵌套类的创建单例语句
    /// </summary>
    public sealed class LogHepler4
    {
        //私有的构造函数，防止用new关键字声明对象
        private LogHepler4() { }
        public static LogHepler4 Instance4
        {
            get
            {
                return Inner.logHepler;
            }
        }

        private static class Inner
        {
            internal static LogHepler4 logHepler = new LogHepler4();
        }
    }
    #endregion

    #region ===========================================5）使用.NET 4 的Lazy 类型===========================================
    /// <summary>
    ///  优点：线程安全的单例，同时他的性能非常好。
    ///  缺点：这里使用.NET4 或者更高版本,可以使用System.Lazy 这个类型声明懒惰的
    /// </summary>
    public sealed class LogHepler5
    {
        private LogHepler5() { }
        public static LogHepler5 Instance5
        {
            get { return _lazy.Value; }
        }
        private static readonly Lazy<LogHepler5> _lazy = new Lazy<LogHepler5>(() => new LogHepler5());
    }
    #endregion

}
