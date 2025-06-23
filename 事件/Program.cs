namespace 事件;

class Test
{
    //委托的申明
    public Action myFun;
    //事件的申明
    public event Action myEvent;

    public Test()
    {
        //二者使用完全一样
        myFun = TestFun;
        myFun += TestFun;
        myFun();
        myFun.Invoke();
        myFun = null;

        myEvent = TestFun;
        myEvent += TestFun;
        myEvent();
        myEvent.Invoke();
        myEvent = null;
    }

    public void TestFun()
    {
        Console.WriteLine("TestFun");
    }

    //事件只能在类内部被封装调用，所以会更安全
    public void DoEvent()
    {
        if(myEvent != null) myEvent();
    }

}

class Program
{
    static void Main(string[] args)
    {
        Test t = new Test();
        //委托可以在外部赋值、调用
        t.myFun = Func;
        t.myFun = null;
        t.myFun();
        t.myFun.Invoke();
        //委托不能在类的外部赋值、调用
        //  t.myEvent = Func;   错误
        //委托可以在外部+=，-=
        t.myEvent += Func;
        //  t.myEvent();        错误

        //委托可以作为临时变量存放函数
        Action f = Func;
        //事件不能作为临时变量存放函数
        //  event Action e = Func;  错误

    }

    static void Func()
    {
        
    }
}
