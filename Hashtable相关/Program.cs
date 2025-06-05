using System.Collections;

Hashtable hashtable = new Hashtable();

//增删查改

//增
//可以有相同value，但是不能有相同key
hashtable.Add(1, 123);
hashtable.Add("123", 321);
hashtable.Add(true, false);
//或者直接用索引器加，用索引器加相同key的时候相当于改了对应value
hashtable[1] = 123;

//删
//1.只能通过key来删
hashtable.Remove(1);
//2.删除不存在的键，不会报错
hashtable.Remove("1");
//3.清空
//  hashtable.Clear();

//查
//1.通过key来查，找不到返回空
Console.WriteLine(hashtable[1]);
//2.通过key查是否存在键值对
if (hashtable.Contains("123")) Console.WriteLine("存在");
if (hashtable.ContainsKey("123")) Console.WriteLine("存在");
//3.通过value查是否存在键值对
if (hashtable.ContainsValue(321)) Console.WriteLine("存在");

//改
//只能改key对应的value，不能改key
hashtable[1] = 321;
Console.WriteLine(hashtable[1]);

//遍历
//键值对数
Console.WriteLine(hashtable.Count);
//通过key遍历：可以遍历key和value
foreach (var key in hashtable.Keys)
{
    Console.WriteLine("key:{0},value:{1}",key ,hashtable[key]);
}
//通过value遍历：只能遍历value
foreach (var value in hashtable.Values)
{
    Console.WriteLine("value:{0}",value);
}
//迭代器遍历键值对
foreach (var item in hashtable)
{
    Console.WriteLine(item);
}
//迭代器遍历
IDictionaryEnumerator enumerator = hashtable.GetEnumerator();
bool flag = enumerator.MoveNext();
while (flag)
{
    Console.WriteLine("key:{0},value:{1}",enumerator.Key,enumerator.Value);
    flag = enumerator.MoveNext();
}