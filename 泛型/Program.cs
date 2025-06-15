namespace 泛型;

#region 泛型类
class TestClass<T>
{
    public T value;
}

//重载——多个泛型占位字母
class TestClass<T1, T2>
{
    public T1 value;
    public T2 value2;
}
#endregion

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
        //类型占位符T可以用任意数据类型代替，这样就实现了类型的参数化
        TestClass<int> t = new TestClass<int>();
        t.value = 10;

        TestClass<string> t2 = new TestClass<string>();
        t2.value = "hello world";

        TestClass<int, string> t3 = new TestClass<int, string>();
        t3.value = 10;
        t3.value2 = "111";


        //泛型方法
        Test2 t4 = new Test2();
        t4.TestFunc<int>(10);
        t4.TestFunc<string>("hello world");
        t4.TestFunc<double>();
        Console.WriteLine(t4.TestFunc<int>("1"));

        //泛型类中的泛型方法
        Test2<int> t5 = new Test2<int>();
        t5.TestFunc<int>(10);
        t5.TestFunc<string>("hello world");
        t5.TestFunc("111"); //编译器会自动推算出T的类型为string，但最好写上，不然可读性不高

    }
}
