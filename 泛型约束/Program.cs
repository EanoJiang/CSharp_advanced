namespace 泛型约束;
#region 各个泛型类型约束
//值类型约束
class Test1<T> where T : struct
{
    public T value;
    public void TestFunc<K>(K v) where K : struct
    {

    }
}

//引用类型约束
class Test2<T> where T : class
{
    public T value;
    public void TestFunc<K>(K v) where K : class
    {

    }
}

//公共无参构造约束
class Test3<T> where T : new()
{
    public T value;
    public void TestFunc<K>(K v) where K : new()
    {

    }
}
class Test1
{

}
class Test2
{
    public Test2(int a)
    {

    }
}
class Test3
{
    private Test3()
    {

    }
}
abstract class Test4
{

}

//类约束：某个类本身或其子类
class Test4<T> where T : Test1
{
    public T value;
    public void TestFunc<K>(K v) where K : Test1
    {

    }
}
class Test1_ : Test1
{

}

//接口约束：某个接口或者其子接口或其子类
interface IFly
{

}
interface IMove : IFly
{
    
}
class Test6 : IFly
{
    
}
class Test5<T> where T : IFly
{
    public T value;
}

//另一个泛型约束
//前者必须是后者本身或其派生类型
class Test7<T, U> where T : U
{
    public T value;
    public void TestFunc<K, V>(K k) where K : V
    {

    }
}
#endregion

#region 约束的组合使用
//同时是引用类型且必须有无参构造函数
class Test8<T> where T : class, new()
{

}
class Test8_
{
    
}
#endregion

#region 多个泛型有约束
class Test9<T,U> where T : class, new() where U : struct
{

}
#endregion
class Program
{
    static void Main(string[] args)
    {
        //值类型
        Test1<int> t = new Test1<int>();
        t.TestFunc<bool>(true);
        // Test1<object> t2 = new Test1<object>();  错误

        //引用类型
        Test2<string> t2 = new Test2<string>();
        t2.TestFunc<object>(new object());

        //无参公共构造函数
        Test3<Test1> t3 = new Test3<Test1>();
        // Test3<Test2> t3 = new Test3<Test2>();    错误，必须要有无参公共构造函数
        // Test3<Test3> t3 = new Test3<Test3>();    错误，必须要有无参公共构造函数
        // Test3<Test4> t3 = new Test3<Test4>();    错误，抽象类不行，因为抽象类不能new对象，只能在子类继承
        Test3<int> t4 = new Test3<int>();   //正确,所有的值类型实际上都默认有一个无参构造

        //类约束：某个类本身或其子类
        Test4<Test1> t5 = new Test4<Test1>();
        t5.TestFunc<Test1>(new Test1());
        //Test1_是Test1的子类
        Test4<Test1_> t6 = new Test4<Test1_>();

        //接口约束
        //接口本身
        Test5<IFly> t7 = new Test5<IFly>();
        t7.value = new Test6();
        //接口的实现类(子类)
        Test5<Test6> t8 = new Test5<Test6>();
        //接口的子接口
        Test5<IMove> t9 = new Test5<IMove>();

        //另一个泛型约束
        //同一类型
        Test7<int, int> t10 = new Test7<int, int>();
        Test7<Test1, Test1> t11 = new Test7<Test1, Test1>();
        //前是后的派生类型
        Test7<Test1_, Test1> t12 = new Test7<Test1_, Test1>();
        Test7<Test6, IFly> t13 = new Test7<Test6, IFly>();

        #region 约束的组合使用
        Test8<Test8_> t14 = new Test8<Test8_>();

        #endregion
    }
}
