![1748674622387](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203740579-1632264547.png)

# 简单数据结构类

## ArrayList

Object类型的数组

### 申明

```csharp
        //ArrayList的申明
        ArrayList arr1 = new ArrayList();
```

### 增删查改

```csharp
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

```

### 排序和反转

和数组一样

```csharp
arr1.Sort();
arr1.Reverse();
```

### 装箱拆箱

```csharp
        #region 装箱拆箱
        //ArrayList本质是一个可以自动扩容的object数组
        //装箱：进行值类型的储存
        //拆箱：进行值类型的取出
        //所以尽量选择其他的数据容器

        int num = 1;
        arr1[0] = num;    //装箱
        num = (int)arr1[0];   //拆箱
  
        #endregion
```

### ArrayList和数组的区别

ArrayList本质是object数组

| 功能                   | 数组                                       | `ArrayList`                                                                  |
| ---------------------- | ------------------------------------------ | ------------------------------------------------------------------------------ |
| **获取长度**     | `数组名.Length`                          | `数组名.Count`                                                               |
| **访问元素**     | `数组名[index]`（直接访问）              | `数组名[index]`（需拆箱）                                                    |
| **修改元素**     | `数组名[index] = value`                  | `数组名[index] = value`                                                      |
| **排序**         | `Array.Sort(数组名)`                     | `数组名.Sort()`                                                              |
| **反转**         | `Array.Reverse(数组名)`                  | `数组名.Reverse()`                                                           |
| **查找索引**     | `Array.IndexOf(数组名, value)`           | `数组名.IndexOf(value)`                                                      |
| **元素是否存在** | ❌                                         | `数组名.Contains(value)`                                                     |
| **清空**         | `Array.Clear(数组名, startIndex, count)` | `数组名.Clear()`                                                             |
| **增删方法**     | 增删方法需要自己写                         | 内置                                                                           |
| **添加元素**     | ❌ 固定大小，不能动态添加                  | `数组名.Add(value)`                                                          |
| **插入元素**     | ❌ 不支持                                  | `数组名`.Insert(index, value)<br />`数组名`.InsertRange(index, 一个集合); |
| **批量添加**     | ❌ 不支持                                  | `数组名`.AddRange(一个集合)                                                  |
| **删除元素**     | ❌ 不支持                                  | `数组名`.Remove(value)<br />RemoveAt(index)                                  |
| **自动扩容**     | ❌ 定长                                   | ✅ 是                                                                          |
| **类型安全**     | ✅ 是                                      | ❌ 否（需手动强制转换）                                                        |
| **性能**         | 高(只要数组不是object数组就不存在装箱拆箱) | 相对较低（存在装箱/拆箱）                                                      |

> 习题

![1748682909040](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203741357-167885152.png)

```csharp
using System.Collections;

class Bag
{
    private ArrayList items;

    private int money;

    public Bag(int money)
    {
        this.money = money;
        items = new ArrayList();
    }
    public void BuyItem(Item item)
    {
        //物品信息错误
        if (item.num <= 0 || item.price <= 0)
        {
            Console.WriteLine("物品信息有误");
            return;
        }
        //金钱变化
        if (money < item.price * item.num)
        {
            Console.WriteLine("钱不够");
            return;
        }
        money -= item.price * item.num;
        //添加物品
        foreach (Item i in items)
        {
            //如果已经在背包里面，必须要比较UID
            //  因为传入的item不会和items里的item是同一个对象，所以要判断UID
            if (i.UID == item.UID)
            {
                //叠加数量
                i.num += item.num;
                return;
            }
        }
        items.Add(item);
        Console.WriteLine("买了{0}个{1}，共花费{2}元", item.num, item.name, item.price * item.num);
        ShowItems();
    }
    //根据item卖
    public void SellItem(Item item)
    {
        //遍历物品
        foreach (Item i in items)
        {
            //要卖的东西在背包里有，必须要比较UID
            if (i.UID == item.UID)
            {
                string name = i.name;
                int price = i.price;
                int sellNum = item.num;
                //买的数量判定
                if (i.num < item.num)
                {
                    sellNum = i.num;  //要卖出的数量超出已有，只能卖出已有的全部
                }
                i.num -= sellNum;
                money += (int)(sellNum * price * 0.8f);
                Console.WriteLine("卖了{0}个{1}，共获得{2}元", sellNum, name, (int)(sellNum * price * 0.8f));
                if (i.num <= 0) items.Remove(i);    //卖完了就要移除当前遍历的该项
                ShowItems();
                return;
            }
        }
        Console.WriteLine("没有这个物品");
        return;
    }
    //根据UID卖
    public void SellItem(int UID, int num = 1)
    {
        Item item = new Item();
        item.UID = UID;
        item.num = num;
        SellItem(item);
    }
    public void ShowItems()
    {
        foreach (Item item in items)
        {
            Console.Write("有{0}个{1}，", item.num, item.name);
        }
        Console.WriteLine("现在手里有{0}元",money);
    }
}

class Item
{
    //单价
    public int price;
    public int UID;
    public string name;
    public int num;
    public Item()
    {
    }
    public Item(int UID, int price, string name, int num)
    {
        this.UID = UID;
        this.price = price;
        this.name = name;
        this.num = num;
    }
}

class Program
{
    static void Main()
    {
        Bag bag = new Bag(10000);
        Item i1 = new Item(1, 10, "sb", 10);
        Item i2 = new Item(2, 20, "sb2", 20);
        Item i3 = new Item(3, 999, "sb3", 3);

        bag.BuyItem(i1);
        bag.BuyItem(i2);
        bag.BuyItem(i3);

        bag.SellItem(2);
        bag.SellItem(i1);

        bag.SellItem(i1);

    }
}
```

## Stack

本质是object[]数组

栈储存容器，后进先出

### 栈的使用

```csharp
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

```

### 栈的装箱拆箱

因为栈的本质还是object[]数组

所以当进行值类型存储(入栈值类型对象)的时候就是装箱，把值类型对象取出来(出栈值类型对象)**转换使用**就是拆箱。

```csharp
//装箱
stack.Push(1);     // int 值类型 → object 引用类型（装箱）
stack.Push(true);  // bool 值类型 → object 引用类型（装箱）
//拆箱
object o = stack.Pop();
int num = (int)o;  // 拆箱：object → int
```

> 如何避免装箱拆箱？

泛型集合：栈泛型 Stack `<Type>`

相当于一个只有栈的存储特性(后进先出)的集合，缺点就是只能存指定类型的元素

入栈出栈都是直接存取，不存在装箱拆箱

```csharp
Stack<int> stack = new Stack<int>();
stack.Push(100);
int value = stack.Pop();  // 直接获取 int，无需拆箱
```

### 栈的应用

UI的显示逻辑(每次点击的面板总是显示在最前面)

高进制转低进制

> 习题

![1749111766924](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203742172-1672713420.png)

对于取出一个后进先出的数组，可以用栈来解决

```csharp
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

```

## Queue

本质是object[]数组，先进先出，类似管道

### 队列的使用

```csharp
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
```

### 队列的装箱拆箱

```csharp
//装箱
queue.Enqueue(123);
//拆箱
int num = (int)queue.Dequeue(); 
```

和栈一样，用**泛型 `Queue<Type> 就可以避免装箱拆箱`**

> 习题

![1749114446931](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203744171-1853171425.png)

```csharp
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
```

## Hashtable

哈希表/散列表，本质是一个字典

是基于键的哈希代码组织起来的键值对 `<key,value>`

用键来访问集合中的元素

### 哈希表的使用

```csharp
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
```

> 注意：哈希表的键值对**排列顺序，取决于 key 的哈希码和冲突处理机制**，并不是按照插入顺序排列的

> 关于迭代器：
>
> foreach**底层调用的就是 `GetEnumerator()`**

### 哈希表的装箱拆箱

本质是object容器，字典，所以必然存在装箱拆箱

```csharp
Hashtable table = new Hashtable();

// 装箱：int → object
table.Add(1, 100);     // key 和 value 都是值类型，会装箱

// 拆箱：object → int
int key = 1;
int value = (int)table[key];  // 拆箱操作
```

> 用字典泛型Dictionary `<Type,Type>`来避免装箱拆箱：

```csharp
Dictionary<int, int> dict = new Dictionary<int, int>();
dict.Add(1, 100);//直接加
int value = dict[1];  // 直接取用
```

> 习题

![1749120828356](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203744919-1361438854.png)

```csharp
using System.Collections;

for (int i = 0; i < 10; i++)
{
    MonsterManager.Instance.AddMonster();
}
MonsterManager.Instance.RemoveMonster(1);
MonsterManager.Instance.RemoveMonster(5);


class MonsterManager
{
    //要让管理器是唯一的 所以用单例模式来实现
    private static MonsterManager _instance = new MonsterManager();
    public static MonsterManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private Hashtable monsterTable = new Hashtable();
    //不让在外面new
    private MonsterManager()
    {

    }

    private int monsterID = 0;
    public void AddMonster()
    {
        Monster monster = new Monster(monsterID);
        monsterTable.Add(monster.id, monster);
        (monsterTable[monsterID] as Monster).Generate();
        monsterID++;
    }

    public void RemoveMonster(int id)
    {
        if (monsterTable.ContainsKey(id))
        {
            (monsterTable[id] as Monster).Dead();
            monsterTable.Remove(id);
        }
    }
}

class Monster
{
    public int id;
    public Monster(int id)
    {
        this.id = id;
    }
    public void Generate()
    {
        Console.WriteLine("生成怪物{0}", id);
    }
    public void Dead()
    {
        Console.WriteLine("怪物{0}死亡", id);
    }
}
```

> 关于单例模式，这个在C# 核心里面提到过

![1749124907995](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203747297-2057162670.png)

这就是一个标准的单例模式书写，在外部不能实例化，只有类名.单例属性名.成员方法()才能调用

![1749125014286](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203747854-1426239643.png)

# 泛型

## 泛型的基本概念

* 泛型实现了**类型参数化**，用于代码复用
* 通过类型参数化来实现在同一份代码上操作多种类型
* **相当于类型占位符**
* 定义类/方法的时候使用替代符来来代表变量类型
* **当真正使用类和方法时再具体制定类型**
* 泛型占位符一般用大写字母

### 泛型的作用

1. 不同类型对象的相同逻辑处理，可以选择泛型，提升代码的复用
2. 使用泛型，可以一定程度**避免装箱拆箱**
3. eg：自己写泛型类ArrayList `<T>`来解决ArrayList存在的装箱拆箱问题、Stack `<Type>`、Queue `<Type>`、用字典 `Dictionary<T1,T2>`实现Hashtable

### 泛型分类

#### 语法

泛型类：		class 类名<泛型占位字母>

泛型接口：	interface 接口名<泛型占位字母>

泛型函数：	函数名<泛型占位字母>

泛型占位字母可以有多个，用逗号隔开

#### 泛型类

```csharp
class TestClass<T>
{
    public T value;
}

//重载——多个泛型占位字母
class TestClass<T1,T2>
{
    public T1 value;
    public T2 value2;
}

class Program
{
    static void Main(string[] args)
    {
        //类型占位符T可以用任意数据类型代替，这样就实现了类型的参数化
        TestClass<int> t = new TestClass<int>();
        t.value = 10;

        TestClass<string> t2 = new TestClass<string>();
        t2.value = "hello world";

        TestClass<int, string> t3 = new TestClass<int, string>();
        t3.value = 10;
        t3.value2 = "111";
    }
}
```

#### 泛型接口

```csharp
#region 泛型接口
interface TestInterface<T>
{
    //接口只能有属性、方法、事件、索引器
    T value { get; set; }
}
//在类中实现接口，因为是实现，所以必须在<>内注明数据类型
class Test : TestInterface<int>
{
    public int value { get; set; }
}
#endregion
```

#### 泛型方法(函数)

> 不确定泛型类型的时候可以用default(T)来获取默认值，然后在后面写函数逻辑

```csharp
#region 普通类中的泛型方法
class Test2
{
    public void TestFunc<T>(T value)
    {
        Console.WriteLine(value);
    }
    //无参
    public void TestFunc<T>()
    {
        T t = default(T);
        Console.WriteLine("{0}类型的默认值是{1}", typeof(T), t);
    }
    //占位符作为返回值类型
    public T TestFunc<T>(string v)
    {
        return default(T);
    }
    //多个占位符
    public void TestFunc<T, T2>(T v1, T2 v2)
    {

    }
}
#endregion
class Program
{
    static void Main(string[] args)
    {
        //泛型方法
        Test2 t4 = new Test2();
        t4.TestFunc<int>(10);
        t4.TestFunc<string>("hello world");
        t4.TestFunc<double>();
        Console.WriteLine(t4.TestFunc<int>("1"));
    }
}
```

#### 泛型类中的泛型方法

```csharp
#region 泛型类中的泛型方法
class Test2<T>
{
    public T value;
    //函数名后没有<>，不是泛型方法
    // 调用函数的时候，参数类型T已经被类的T定死，无法重新指定其数据类型
    public void TestFunc(T v)
    {

    }
    //函数名后有<>，才是泛型方法
    // 括号里的参数类型T只与该函数的<T>一致，和类的T无关
    public void TestFunc<T>(T v)
    {

    }
}
#endregion
class Program
{
    static void Main(string[] args)
    {
        //泛型类中的泛型方法
        Test2<int> t5 = new Test2<int>();
        t5.TestFunc<int>(10);
        t5.TestFunc<string>("hello world");
        t5.TestFunc("111"); //编译器会自动推算出T的类型为string，但最好写上，不然可读性不高
    }
}
```

> 习题

![1749802246428](image/CSharp_advanced/1749802246428.png)

```csharp
namespace 泛型习题;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Test<int>());
    }

    static string Test<T>()
    {

        if (typeof(T) == typeof(int))
        {
            return String.Format("{0},{1}字节", typeof(T), sizeof(int));
        }
        else if (typeof(T) == typeof(double))
        {
            return String.Format("{0},{1}字节", typeof(T), sizeof(double));
        }
        else if (typeof(T) == typeof(float))
        {
            return String.Format("{0},{1}字节", typeof(T), sizeof(float));
        }
        else if (typeof(T) == typeof(char))
        {
            return String.Format("{0},{1}字节", typeof(T),sizeof(char));
        }
        else if (typeof(T) == typeof(string))
        {
            return String.Format("{0}", typeof(T));
        }
        else
        {
            return String.Format("其他类型");
        }
    }
}

```

### 泛型类和泛型接口


### 泛型方法

### 泛型的作用

### 总结

## 泛型约束

# 常用泛型数据结构类

# 委托和事件

# List排序

# 协变逆变

# 多线程

# 预处理器指令

# 反射和特性

# 迭代器

# 特殊语法

# 各种排序

# 游戏常用查找(寻路)
