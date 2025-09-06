using System.Reflection;

namespace 反射;

class Test
{
    private int i = 1;
    public int j = 2;
    public string str = "123";
    public Test() { }
    public Test(int i)
    {
        this.i = i;
    }
    public Test(int i, string str) : this(i)
    {
        this.str = str;
    }
    public void Speak()
    {
        Console.WriteLine(i);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // #region Type
        // //获取Type：
        // //  1.object中的.GetType()获取对象的Type
        // int a = 42;
        // Type type = a.GetType();
        // Console.WriteLine(type);
        // //  2.通过typeof关键字，传入类名，获取对象的Type
        // Type type2 = typeof(int);
        // Console.WriteLine(type2);
        // //  3.通过类名，获取对象的Type
        // Type type3 = Type.GetType("System.Int32");
        // Console.WriteLine(type3);

        // //得到类的程序集信息：
        // //  通过Type变量名.Assembly得到类型所在程序集信息
        // Console.WriteLine(type.Assembly);

        // //获取类中的所有公共成员：
        // //  先得到类的Type
        // Type t = typeof(Test);
        // //  用.GetMembers()获取类中的所有公共成员，需要先using System.Reflection;
        // MemberInfo[] infos = t.GetMembers();
        // foreach (var info in infos)
        // {
        //     Console.WriteLine(info);
        // }

        // Console.WriteLine("__________");

        // //获取类的公共构造函数并调用：
        // //  1.用.GetConstructors()获取所有构造函数
        // ConstructorInfo[] cis = t.GetConstructors();
        // foreach (var ci in cis)
        // {
        //     Console.WriteLine(ci);
        // }
        // //  2.用GetConstructor()获取其中一个构造函数并用.Invoke()执行
        // //步骤如下：
        // //得构造函数，传入Type数组，数组中的内容按顺序填入typeof(构造函数参数类型)
        // //执行构造函数，传入object数组，数组中按顺序传入参数

        // //  无参构造
        // //      得到无参构造，直接传参new Type[0]
        // ConstructorInfo info1 = t.GetConstructor(new Type[0]);
        // //      用.Invoke()执行无参构造，传参null
        // Test obj = info1.Invoke(null) as Test;
        // Console.WriteLine(obj.j);

        // //  有参构造
        // //      得到有参构造，直接传参new Type[]{typeof(int)}
        // ConstructorInfo info2 = t.GetConstructor(new Type[] { typeof(int) });
        // obj = info2.Invoke(new object[] { 1 }) as Test;
        // Console.WriteLine(obj.str);

        // ConstructorInfo info3 = t.GetConstructor(new Type[] { typeof(int), typeof(string) });
        // obj = info3.Invoke(new object[] { 1, "fuck" }) as Test;
        // Console.WriteLine(obj.str);

        // //获取类的公共成员变量：
        // //  1.用.GetFields()得到所有公共成员变量，存在FieldInfo[]数组中
        // FieldInfo[] fields = t.GetFields();
        // foreach (FieldInfo field in fields)
        // {
        //     Console.WriteLine(field);
        // }
        // //  2.用.GetField("公共成员变量名")得到指定名称的公共成员变量，存在FieldInfo中
        // FieldInfo infoJ = t.GetField("j");
        // Console.WriteLine(infoJ);
        // FieldInfo infoStr = t.GetField("str");
        // Console.WriteLine(infoStr);

        // //  3.通过反射获取和设置对象的值
        // Test test = new Test();
        // test.j = 99;
        // test.str = "2222";
        // //      通过反射，用 对象的某个成员变量名.GetValue(对象名) 获取对象的某个成员变量的值
        // Console.WriteLine(infoJ.GetValue(test));
        // //      通过反射，用 对象的某个成员变量名.SetValue(对象名, 要设置的值) 设置指定对象的某个成员变量的值
        // infoJ.SetValue(test, 999);
        // Console.WriteLine(infoJ.GetValue(test));

        // //获取类的公共成员方法：
        // //通过Type类的GetMethod()方法，获取类中的公共方法，存在MethodInfo中
        // Type strType = typeof(string);
        // MethodInfo[] methodInfos = strType.GetMethods();
        // foreach (MethodInfo methodInfo in methodInfos)
        // {
        //     Console.WriteLine(methodInfo);
        // }
        // //  1.如果有方法重载，用Type数组表示参数类型
        // MethodInfo subStr = strType.GetMethod("Substring",
        //                             new Type[] { typeof(int), typeof(int) });
        // //  2.调用该方法
        // //  注意：如果是静态方法，Invoke()中的第一个参数要传入null
        // string str = "1234567890";
        // object result = subStr.Invoke(str, new object[] { 2, 4 });
        // Console.WriteLine(result);

        // //其他获得：
        // //  得枚举：GetEnumName
        // //  得事件：GetEvent
        // //  得属性：GetProperty
        // //  得接口：GetInterface  

        // #endregion

        #region Activator
        //先得到Type
        Type testType = typeof(Test);
        //1.无参构造Activator.CreateInstance(Type对象)
        Test testObject = Activator.CreateInstance(testType) as Test;
        Console.WriteLine(testObject.str);
        //2.有参构造Activator.CreateInstance(Type对象,参数)
        testObject = Activator.CreateInstance(testType, 99) as Test;
        Console.WriteLine(testObject.j);
        testObject = Activator.CreateInstance(testType, 99, "111111") as Test;
        Console.WriteLine(testObject.str);
        #endregion

        #region Assembly
        //三种加载程序集的方法
        //1.Load("程序集名称")  同一文件下的其他程序集
        Assembly a1 = Assembly.Load("System");
        //2.LoadFrom("程序集绝对路径")  加载一个完整的程序集及其依赖
        //注意：可以用反转义字符@
        Assembly a2 = Assembly.LoadFrom("/Users/User/Desktop/CSharp/CSharp_advanced/反射/bin/Debug/net7.0/反射.dll");
        //3.LoadFile("程序集绝对路径")  仅加载指定文件中的程序集，不处理依赖
        Assembly a3 = Assembly.LoadFile("/Users/User/Desktop/CSharp/CSharp_advanced/Lesson18_练习题/bin/Debug/netcoreapp3.1/Lesson18_练习题.dll");
        Type[] types = a3.GetTypes();
        foreach (Type t in types)
        {
            Console.WriteLine(t);
        }
        //加载完程序集中的类对象，下面使用反射
        Type icon = a3.GetType("Lesson18_练习题.Icon");
        MemberInfo[] members = icon.GetMembers();
        foreach (MemberInfo m in members)
        {
            Console.WriteLine(m);
        }
        //通过反射实例化
        //这是一个枚举Type
        Type moveDir = a3.GetType("Lesson18_练习题.E_MoveDir");
        FieldInfo right = moveDir.GetField("Right");
        //直接实例化对象
        object iconObj = Activator.CreateInstance(icon, 10, 5, right.GetValue(null));
        //通过反射得到对象中的方法
        MethodInfo move = icon.GetMethod("Move");
        MethodInfo draw = icon.GetMethod("Draw");
        MethodInfo clear = icon.GetMethod("Clear");

        Console.Clear();
        while (true)
        {
            Thread.Sleep(1000);
            clear.Invoke(iconObj, null);
            move.Invoke(iconObj, null);
            draw.Invoke(iconObj, null);
        }

        #endregion
    }
}
