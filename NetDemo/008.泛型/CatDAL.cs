using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008.泛型
{
    internal class CatDAL<T, K, V, W, X, Y>
                           where T : struct        //约束 T 必须是值类型  
                           where K : class         //约束 K 必须是引用类型   
                           where V : IAnimalDAL<K>      //约束 V 必须实现 IFace 接口  
                           where W : K             //约束 W 必须是 K 类型，或者是 K 类型的子类  
                           where X : class, new()  //约束 X 必须是引用类型，并且有一个无参数的构造函数，当有多个约束时，new()必须写在最后  
                           where Y : AnimalDAL<Y>      //约束 Y 必须是 MyClass2 类型，或者继承于 MyClass2 类
    {
        /// <summary>
        /// 保存方法
        /// </summary>
        /// <param name="model"></param>
        public void Save(T model)
        {
            Console.WriteLine("我是泛型类中的方法，成功保存了一条数据。");
        }
    }
}
