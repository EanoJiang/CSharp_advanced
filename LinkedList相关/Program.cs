//申明
LinkedList<int> linkedList = new LinkedList<int>();
LinkedList<string> linkedList2 = new LinkedList<string>();

//增删查改
#region 增
//头插
linkedList.AddFirst(1);
//尾插
linkedList.AddLast(99);
//在指定节点后插入
LinkedListNode<int> n = linkedList.Find(1);
linkedList.AddAfter(n, 2);
//在指定节点前插入
linkedList.AddBefore(n, 0);

#endregion

#region 删
//删除头节点
linkedList.RemoveFirst();
//删除尾节点
linkedList.RemoveLast();
//删除指定值的节点
//无法通过位置删除，因为链表没有办法直接获取索引
linkedList.Remove(99);
//清空
linkedList.Clear();
#endregion

linkedList.AddLast(1);
linkedList.AddLast(2);

#region 查
//获取头节点
LinkedListNode<int> first = linkedList.First;
//获取尾节点
LinkedListNode<int> last = linkedList.Last;
//获取指定值的节点
LinkedListNode<int> node = linkedList.Find(1);
Console.WriteLine(node.Value);
//判断是否存在
Console.WriteLine(linkedList.Contains(1));
#endregion

#region 改
Console.WriteLine(node.Value);
node.Value = 3;
Console.WriteLine(node.Value);
#endregion

#region 遍历
//迭代器
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
//通过节点遍历：因为本质是双向链表，所以存在正序和倒序遍历
//1.正序遍历
LinkedListNode<int> nowNode = linkedList.First;
while (nowNode != null)
{
    Console.WriteLine(nowNode.Value);
    nowNode = nowNode.Next;
}
//2.倒序遍历
nowNode = linkedList.Last;
while (nowNode != null)
{
    Console.WriteLine(nowNode.Value);
    nowNode = nowNode.Previous;
}
#endregion