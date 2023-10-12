// 这是 Program.cs 类

using _008.泛型;
using _008.泛型.应用实例;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static _008.泛型.PrintHelper;

//1.常规写法，需要定义三个方法
Console.WriteLine("1.常规写法，需要定义三个方法：");
new PrintHelper().PrintInt(100);
new PrintHelper().PrintFloat(100.0f);
new PrintHelper().PrintString("abc");

//2.泛型写法，只需要定义一个方法
Console.WriteLine("\n2.泛型写法，只需要定义一个方法：");
new PrintHelper().Print<int>(100);
new PrintHelper().Print<float>(100.0f);
new PrintHelper().Print<string>("abc");

//3.泛型委托的使用
Console.WriteLine("\n3.泛型委托的使用：");
MyDelegate<int> myDelegate = new PrintHelper().Print;
myDelegate(100);

MyDelegate<float> myDelegate2 = new PrintHelper().Print;
myDelegate2(200.0f);

MyDelegate<string> myDelegate3 = new PrintHelper().Print;
myDelegate3("abcd");

//4.泛型接口的使用
Console.WriteLine("\n4.泛型接口的使用：");
IAnimalDAL<string> animal = new AnimalDAL<string>();
animal.Save("abcde");
animal.Query("abcde");

//5.泛型类的使用
Console.WriteLine("\n5.泛型类的使用：");
new DogDAL<string>().Save("abcde");
new DogDAL<string>().Query("abcde");

//6.泛型应用实例
DataTable dataTable = new DataTable();
dataTable.Columns.Add("ID");
dataTable.Columns.Add("Name");
dataTable.Columns.Add("Count", typeof(System.Int32));

DataRow dataRow = dataTable.NewRow();
dataRow[0] = "S001";
dataRow[1] = "Tom";
dataRow[2] = "55";
dataTable.Rows.Add(dataRow);

dataRow = dataTable.NewRow();
dataRow[0] = "S002";
dataRow[1] = "Jack";
dataRow[2] = "30";
dataTable.Rows.Add(dataRow);

dataRow = dataTable.NewRow();
dataRow[0] = "S003";
dataRow[1] = "Lucy";
dataRow[2] = "34";
dataTable.Rows.Add(dataRow);

List<Cat> cats = ConvertHelper<Cat>.DtToList(dataTable);
foreach (var cat in cats)
{
    Console.WriteLine($"Id:{cat.ID};Name:{cat.Name};Count:{cat.Count}");
}

//List<Cat> list = new List<Cat>();
//list.Add(new Cat() { ID = "S001", Name = "Tom", Count = 100 });
//list.Add(new Cat() { ID = "S002", Name = "Jack", Count = 66 });
//list.Add(new Cat() { ID = "S003", Name = "Lucy", Count = 88 });
//DataTable dt = ConvertHelper<Cat>.ListToDt(list);

//List<Cat> cats = ConvertHelper<Cat>.DtToList(dt);
//foreach (var cat in cats)
//{
//    Console.WriteLine($"Id:{cat.ID};Name:{cat.Name};Count:{cat.Count}");
//}