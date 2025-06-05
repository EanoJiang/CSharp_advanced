using System.Collections;


//栈的申明
Stack stack = new Stack();

//增删查改

//压栈
stack.Push("1");
stack.Push(true);
stack.Push(1);
stack.Push(new Test());

//出栈
object o1 = stack.Pop();
Console.WriteLine(o1);

//查看栈顶
object o2 = stack.Peek();
Console.WriteLine(o2);
//是否在栈中
if (stack.Contains(1)) Console.WriteLine("存在1");

//清空
//  stack.Clear();

//遍历
//1.长度
Console.WriteLine(stack.Count);
//2.用foreach遍历
foreach (object o in stack)
{
    Console.WriteLine(o);
}
//3.转成object数组遍历,顺序也是从栈顶到栈底
object[] arr = stack.ToArray();
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine();
Console.WriteLine(stack.Count);
//4.循环弹栈
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}
Console.WriteLine(stack.Count);

class Test
{

}
