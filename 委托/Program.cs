namespace 委托;
//委托的申明，统一语句块中不能重名
delegate void MyFunc();
public delegate int MyFunc2(int a);

//泛型委托
delegate T MyFunc3<T, K>(T t, K k);

#region 使用定义好的委托
//委托常用在：
//1.作为类的成员
//2.作为函数的参数
class Test
{
    public MyFunc func;
    public MyFunc2 func2;
    public void TestFunc(MyFunc func, MyFunc2 func2)
    {
        //观察者设计模式
        //先处理一些逻辑，后 存放/延迟执行 传入的函数
        int i = 0;
        i++;

        //延迟执行传入的函数
        //func();
        //func2(i);

        //存放传入的函数
        this.func = func;
        this.func2 = func2;
    }
    #region 委托变量存储多个函数
    //同样，需要格式一致才能装载
    //增    +=
    public void AddFunc(MyFunc func, MyFunc2 func2)
    {
        this.func += func;
        this.func2 += func2;
    }

    //删    -=
    public void RemoveFunc(MyFunc func, MyFunc2 func2)
    {
        this.func -= func;
        this.func2 -= func2;
    }
    #endregion
}
#endregion


class Program
{
    static void Main(string[] args)
    {
        //委托是专门装载函数的容器
        //把格式一样(无参无返回值)的方法Fun装进了MyFunc的对象f里面
        //两种存放写法
        MyFunc f = new MyFunc(Fun);
        MyFunc f2 = Fun;

        //调用委托对象f存放的方法
        //两种调用写法
        f.Invoke();
        f2();

        //注意：格式必须一样才能装载
        MyFunc2 f3 = new MyFunc2(Fun2);
        Console.WriteLine(f3(1));

        #region 使用定义好的委托
        Test t = new Test();
        t.TestFunc(Fun, Fun2);
        #endregion

        #region 委托变量存储多个函数
        //同样，需要格式一致才能装载

        //增    +=
        // MyFunc ff = Fun;
        // ff += Fun3;
        // ff();

        //或者：先赋值为null，再+=
        MyFunc ff = null;
        ff += Fun;
        ff += Fun3;
        ff();

        t.AddFunc(Fun, Fun2);
        t.func();

        //删    -=
        ff -= Fun;
        //多删不会报错
        ff -= Fun;
        ff();
        ff -= Fun3;
        //删完会报错
        // ff();     删完，ff为null，调用会报错
        //清空委托容器
        // ff = null;
        if (ff != null) ff();
        #endregion

        Console.WriteLine("*******************");
        #region 系统定义好的委托容器
        //无参无返回 —— Action
        Action action = Fun;
        action += Fun3;
        action();
        //n个参数无返回，最多支持传入16个参数 —— Action<T1,T2,T3...T16>
        Action<int, string> actions = Fun6;
        actions(1, "111");

        //无参有返回的泛型委托 —— Func<T>
        Func<string> funcString = Fun4;
        Func<int> funcInt = Fun5;
        //n个参数有返回，最多支持传入16个参数 —— Func<T1,T2,T3...T16,TResult>
        //注意：参数的类型写前面，返回值的类型写后面
        Func<int, string> funcs = Fun7; //参数是int，返回值是string
        #endregion

    }

    static void Fun()
    {
        Console.WriteLine("这是Fun方法");
    }
    static void Fun3()
    {
        Console.WriteLine("这是Fun3方法");
    }
    static int Fun2(int value)
    {
        return value;
    }
    static string Fun4()
    {
        return "这是Fun4方法";
    }
    static int Fun5()
    {
        return 5;
    }
    static void Fun6(int value, string value2)
    {

    }
    static string Fun7(int value)
    {
        return "这是Fun7方法";
    }
}
