using System.Collections.Generic;

//申明
List<int> list = new List<int>();

//增删查改

#region 增
//单个加
list.Add(1);
list.Add(2);

List<int> list2 = new List<int>();
list2.Add(1);
//范围加
list.AddRange(list2);
//在指定位置插入
list.Insert(0, 999);
#endregion

#region 删
//移除指定元素
list.Remove(1);
//移除指定位置元素
list.RemoveAt(0);
//清空
list.Clear();
#endregion

list.Add(1);
list.Add(2);
list.Add(3);

#region 查
//得到指定位置元素
Console.WriteLine(list[0]);
//元素是否存在
Console.WriteLine(list.Contains(1));
//正向查找元素位置
//找不到返回-1
Console.WriteLine(list.IndexOf(1));
Console.WriteLine(list.IndexOf(0));
//反向查找元素位置,返回的也是从左往右数的位置，只是从末尾开始遍历
//找不到返回-1
Console.WriteLine(list.LastIndexOf(1));
Console.WriteLine(list.LastIndexOf(0));
#endregion

#region 改
list[0] = 999;

#endregion

Console.WriteLine();
#region 遍历
Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
foreach (var item in list)
{
    Console.WriteLine(item);
}
#endregion