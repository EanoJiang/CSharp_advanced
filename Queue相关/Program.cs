using System.Collections;

Queue queue = new Queue();
//增删查改
//入队  
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(new Test());
//出队
object o = queue.Dequeue();
Console.WriteLine(o);
//查看队头
o = queue.Peek();
Console.WriteLine(o);
//是否在队列中
if (queue.Contains(3)) Console.WriteLine("在队列中");
//清空
//  queue.Clear();

//遍历
//1.长度
Console.WriteLine(queue.Count);
//2.用foreach遍历
foreach (object item in queue)
{
    Console.WriteLine(item);
}
//3.转成object[]数组遍历
object[] arr = queue.ToArray();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
//4.循环出队列
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}   

class Test
{

}