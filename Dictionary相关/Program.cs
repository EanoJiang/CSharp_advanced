using System.Collections.Generic;

//申明
Dictionary<int, string> dictionary = new Dictionary<int, string>();

//增删查改

#region 增
dictionary.Add(1, "111");
dictionary[2] = "222";
#endregion

#region 删
//1.通过键删除
//删除不存在的键，不报错
dictionary.Remove(1);
//2.清空
dictionary.Clear();
#endregion

dictionary.Add(1, "111");
dictionary.Add(2, "222");
dictionary.Add(3, "333");

#region 查
//1.通过键查询
//找不到键就报错，不返回空
Console.WriteLine(dictionary[1]);
//2.查看是否存在
//根据key
Console.WriteLine(dictionary.ContainsKey(1));  
//根据value
Console.WriteLine(dictionary.ContainsValue("222"));
#endregion

#region 改
dictionary[2] = "9999";
#endregion

//遍历
Console.WriteLine(dictionary.Count);
//一起遍历
foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + ":" + item.Value);
}
foreach (KeyValuePair<int,string> item in dictionary)
{
    Console.WriteLine(item);
}
//遍历key
foreach (var item in dictionary.Keys)
{
    Console.WriteLine(item);
}
//遍历value
foreach (var item in dictionary.Values)
{
    Console.WriteLine(item);
}