using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //ArrayList的申明
        ArrayList arr1 = new ArrayList();

        //增删查改

        //  增
        //尾插法
        //可以增任何类型
        arr1.Add("张三");
        arr1.Add(1);
        arr1.Add(true);
        arr1.Add(new object());
        //批量增加，把另一个list容器里的所有元素都添加到当前容器的后面
        arr1.AddRange(new ArrayList() { "张三", "李四", "王五" });
        //在中间指定位置插入
        arr1.Insert(2, "111111");
        //批量插入
        arr1.InsertRange(3, new ArrayList() { "123", "234", "345" });

        //  删
        //从前往后遍历，删除首个匹配的元素
        arr1.Remove("张三");
        //删除指定位置的元素
        arr1.RemoveAt(0);
        //清空
        //  arr1.Clear();

        //  查
        //获取指定位置的元素
        Console.WriteLine(arr1[0]);
        //查看元素是否存在
        if (arr1.Contains("1")) Console.WriteLine("存在");
        //正向查找元素位置，找不到返回-1
        int index = arr1.IndexOf(true);
        Console.WriteLine(index);
        //反向查找元素位置，返回的索引还是从前开始计数的，找不到返回-1
        index = arr1.LastIndexOf(true);
        Console.WriteLine(index);

        //  改
        arr1[0] = "999";
        Console.WriteLine(arr1[0]);

        Console.WriteLine();

        //长度，数组的元素个数
        Console.WriteLine(arr1.Count);
        //容量
        //用来避免每次改动数组都产生垃圾，有了容量的存在，只有扩容的时候才产生垃圾
        Console.WriteLine(arr1.Capacity);

        //遍历
        //一般的遍历
        for (int i = 0; i < arr1.Count; i++)
        {
            Console.WriteLine(arr1[i]);
        }
        //迭代器遍历
        foreach (object obj in arr1)
        {
            Console.WriteLine(obj);
        }

        #region 装箱拆箱
        //ArrayList本质是一个可以自动扩容的object数组
        //装箱：进行值类型的储存
        //拆箱：进行值类型的取出
        //所以尽量选择其他的数据容器

        int num = 1;
        arr1[0] = num;    //装箱
        num = (int)arr1[0];   //拆箱

        #endregion
    }
}
