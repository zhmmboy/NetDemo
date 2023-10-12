using System.Collections;
using System.Data;
using System.Reflection;

namespace _008.泛型.应用实例
{
    public class ConvertHelper<T> where T : class, new()
    {
        /// <summary>
        /// 数据表转换为数据集合
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> DtToList(DataTable dt)
        {
            List<T> ts = new List<T>(); // 定义集合
            Type type = typeof(T);      // 获得此模型的类型
            string tempName = "";
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
                foreach (PropertyInfo pi in propertys)
                {
                    tempName = pi.Name;
                    if (dt.Columns.Contains(tempName))
                    {
                        if (!pi.CanWrite) continue;
                        object value = dr[tempName];
                        if (value != DBNull.Value)
                            pi.SetValue(t, value, null);
                    }
                }
                ts.Add(t);
            }
            return ts;
        }

        /// <summary>
        /// 数据集合转换为数据表
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static DataTable ListToDt(IEnumerable<T> collection)
        {
            var props = typeof(T).GetProperties();
            var dt = new DataTable();
            dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
            if (collection.Count() > 0)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in props)
                    {
                        object obj = pi.GetValue(collection.ElementAt(i), null);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    dt.LoadDataRow(array, true);
                }
            }
            return dt;
        }
    }
}
