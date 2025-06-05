using System.Collections;

Queue queue = new Queue();
for (int i = 0; i < 10; i++)
{
    queue.Enqueue(i);
}
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
    //隔停100毫秒
    Task.Delay(100).Wait();
}