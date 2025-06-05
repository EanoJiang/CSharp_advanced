using System.Collections;

Console.WriteLine("请输入一个整数");
uint num = (uint.Parse)(Console.ReadLine());
DecToBinary(num);

static void DecToBinary(uint num)
{
    Stack stack = new Stack();
    while (num != 0)
    {
        stack.Push(num % 2);
        num /= 2;
    }
    Console.Write("二进制为：");
    while (stack.Count != 0)
    {
        Console.Write(stack.Pop());
    }
    Console.WriteLine();
}
