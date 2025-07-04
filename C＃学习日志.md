# C#入门篇

> [EanoJiang/CSharp-: C#入门教程，自用](https://github.com/EanoJiang/CSharp-)

> 程序思维题：

两根不均匀的香，烧完一根是1h，怎么用来计时15min呢？

思路：一根香从两头同时点燃烧完是30min，只需再对半即可，那么怎么对半呢？可以在第一根香两端同时点燃的时候也点燃第二根香的一端，这样，当第一根香烧完的时候第二根香还剩30min可以烧，这时候再点燃第二根香的另一端，开始计时，烧完则是在30min可烧的时间再次对半，即为15min。

![1743009839348](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012751994-1617730500.png)

## C#基本结构

```cs
/// <summary>
/// 引用命名空间（工具包），相当于头文件
/// </summary>
using System;

/// <summary>
/// 命名空间（工具包），相当于自定义的头文件
/// </summary>
namespace lesson1;

/// <summary>
/// 类
/// </summary>
class Program
{
    /// <summary>
    /// 主函数
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        ////WriteLine(),Write()
        //Console.WriteLine("自带换行的print");
        //Console.Write("不带换行的print");
        //Console.Write("你看就没有换行");

        ////ReadLine():输入完需要按回车
        //Console.WriteLine("请输入：");
        //Console.ReadLine();
        //Console.WriteLine("over");

        //ReadKey():输入一个键，自动回车
        Console.ReadKey();
        Console.WriteLine("\nover");
    }
}
```

## 注释

三杠注释：用来注释 类、函数

```cs
/// <summary>
/// 
/// </summary>
/// <param name="args"></param>
```

其他注释和c++一样

## 控制台函数

控制台输入：Console.ReadLine()、Console.ReadKey()
控制台输出：Console.WriteLine()、Console.Write()

//WriteLine():打印信息后换行
//Write():打印信息后不换行

```cs
Console.WriteLine("自带换行的print");
Console.Write("不带换行的print");
Console.Write("你看就没有换行");
```

![1743009870599](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012752823-1014372322.png)//ReadLine():检测用户的一系列输入，回车结束
输入完需要按回车才结束

```cs
Console.WriteLine("请输入：");
Console.ReadLine();
Console.WriteLine("over");
```

//ReadKey():检测用户的一键输入，立刻结束
输入一个键，就结束

```cs
//ReadKey():输入一个键，自动回车
Console.ReadKey();
Console.WriteLine("\nover");
```

## 变量

1. 折叠代码

```cs
//折叠代码

# region 这是一段折叠的代码

# endregion
```

2. 变量

```cs

#region 变量
//有符号(signed)的整型变量
//sbyte -2^7 ~ 2^7-1 1字节

//short -2^15 ~ 2^15-1 2字节

//int -2^31 ~ 2^31-1 4字节

//long -2^63 ~ 2^63-1 8字节

//无符号(unsigned)的整型变量
//byte 0 ~ 2^8-1 1字节

//ushort 0 ~ 2^16-1 2字节

//uint 0 ~ 2^32-1 4字节

//ulong 0 ~ 2^64-1 8字节

//浮点型变量
//float 4字节，精度7位有效数字
//不加f后缀，默认是double类型
float f1 = 1.221312f;
//如果是一个整数也可以用float定义，且可以不写f后缀
float myHeight = 183;
//double 8字节，精度15位有效数字
double d1 = 1.2213124211249;
//decimal 16字节，精度28位有效数字

//其他类型变量
//bool 1字节，true或false
bool b1 = true;
bool b2 = false;
//可以与字符串相加
Console.WriteLine(b1 + "and" +b2);
//char 2字节，表示一个字符，用''
char c1 = 'a';
//string 字符串，没有上限，用""
string str1 = "hello world";

//注意修改变量直接再赋值就行了

#endregion
```

```cs
#region 潜在知识点
//拼接输出
int num = 1;
Console.WriteLine("num is :" + num);

#endregion

```

3. 同类型变量可以在同一行声明

```cs
int a = 1, b = 2;
```

4. 变量初始化：声明完变量最好立刻赋值。
5. 内存空间大小：

```

// sizeof()不能用来计算string类型，其他都可以
```

**题目**：

![1743009989549](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012753237-1156797104.png)

```cs
//有符号整型 字节 （位数=字节数*8）
sbyte 1
short 2
int   4
long  8
//无符号整型
byte   1
ushort 2
uint   4
ulong  8

//浮点数
float   4
double  8
decimal 16

//其他
bool   1
char   2
string
```

6. 声明变量

```cs
驼峰命名：变量
int playerName;
帕斯卡命名：类，函数
public void PlayerJump()
{

}
class PlayerJumpState
{

}
```

## 常量

```cs
#region 常量
//关键字：const

//声明的时候要带上类型
//必须初始化
//常量不能修改

const float PI = 3.1415926f;
const string userName = "飞舞";

#endregion
```

常量：用来声明一些不想被修改的变量

## 转义字符

```cs
#region 转义字符
// \' 单引号
// \" 双引号
Console.WriteLine("123\'123");
Console.WriteLine("123\"123");

// \\ 反斜杠
Console.WriteLine("123\\123");

// \n 换行
Console.WriteLine("123\n123");

// \t 制表符
Console.WriteLine("123\t123");

// \b 退格
Console.WriteLine("123\b123");

// \f 换页 就是上下行文本错开
Console.WriteLine("123\f123");

// \0 空字符
Console.WriteLine("123\0123");

// \a 系统警报音
Console.WriteLine("123\a123");

// 取消转义字符
Console.WriteLine(@"123\a123");

#endregion
```

## 类型转换

### 1. 隐式转换

规则：大范围装小范围

```csharp
        #region 隐式转换————同一大类型之间
  
        //有符号
        long l = 1;
        int i = 1;
        short s = 1;
        sbyte sb = 1;
        //下面用隐式转换：大范围装小范围的类型  long -> int -> short -> sbyte
        l = i;
        l = s;
        l = sb;
        //如果反过来装，则会数据溢出，报错
        //比如：i = l;错误

        //无符号
        ulong ul = 1;
        uint ui = 1;
        ushort us = 1;
        byte b = 1;
        //也是大范围装小范围的类型  ulong -> uint -> ushort -> byte

        //浮点数
        decimal de = 1.1m;
        double d = 1.1;
        float f = 1.1f;
        //decimal类型不能隐式转换，不能用来存储double和float
        //比如：de = d; 错误
        //但是float和double可以隐式转换   double -> float
        d = f;

        //特殊类型  bool char string
        //不是同一大类型，不存在隐式转换

        #endregion

```

```csharp
        #region 隐式转换————不同大类型之间
  
            #region 无符号和有符号之间
            //无符号
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号    装不了，因为无符号不存在符号位
            //比如：b2 = sb2; 错误

            //有符号装无符号    能隐式转换的前提是有符号的范围要更大，才能装下无符号的范围
            i2 = b2;
            l2 = i2;
            // 比如：i2 = ui2; 错误

            #endregion

            #region 整型和浮点型之间
            //浮点数
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;
  
            //浮点数装整数  浮点数可以装任意整数 还是大范围装小范围
            //decimal虽然不能隐式存储double和float，但是可以隐式存储整形
            f2 = i2;
            de2 = i2;
            /*总结*/
            // double -> float -> 所有整形（有无符号都行）
            // decimal -> 所有整形（有无符号都行）

            //整数装浮点数  不行，因为整数的范围比浮点数的范围小，而且整数也没小数位置



            #endregion

            #region 特殊类型和其他类型之间
            bool bo2 = true;
            char c2 = 'a';
            string str2 = "hello";
            //bool 不能和其他类型 相互隐式转换
                // i2 = bo2;
                // bo2 = i2;
                // 均报错
            //char 不能隐式转换成其他类型，但是可以隐式转换成整形浮点型大范围的类型
                // c2 = i2; 报错
                i2 = c2;
                f2 = c2;
            //string 不能和其他类型 相互隐式转换
                // str2 = i2;
                // i2 = str2;
                // 均报错
  




            #endregion





        #endregion

```

**题目：**

![1741801953087](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012754070-779318737.png)

*~~哈哈，这里出现了一个搞心态的markdown bug，就是如果图片地址有特殊符号，比如这个md文件名有#符号，那粘贴过来的图片会显示地址不存在。~~*

```csharp
       //作业：
        int tang = '唐';
        int lao = '老';
        int shi = '狮';
        Console.WriteLine("名字："+tang+lao+shi);//前面是字符串，后面相连也就是字符串拼接

```

### 2.显式转换

#### 2.1 括号强转

(目标类型)源类型变量名

```csharp
        #region 显式转换————括号强转
            //用于：将高精度的类型强制转换为低精度的类型
	    //	低精度 装 高精度， 大范围存小范围
            //语法： (目标类型) 源类型变量名
	    // long l1 = 1;
            // int i1 = (int) l1;
            //long l1 = (long) i1; 错误，低精度不能强转高精度，也就是高精度不能存放低精度

            //注意：精度问题(浮点数) 范围问题
            //相同大类的整形
            sbyte sb1 = 1;
            short s1= 1;
            int i1 = 1;
            long l1 = 1;

            s1 = (short)i;//小存大会因为范围产生异常，但不会报错
  
            //浮点数
            float f1 = 1.1f;
            double d1 = 1.1124234213f;
            decimal de1 = 1.1m;

            f1 = (float)d1; //小存大会精度丢失，但不会报错
            Console.WriteLine(f1);

            //无符号和有符号
            uint ui1 = 1;
            i1 = (int)ui1;
            Console.WriteLine(i1);
            i1 = -1;
            ui1 = (uint)i1; //无符号存有符号，会因为缺少符号位产生异常，但不会报错
            Console.WriteLine(ui1);
  
            //浮点和整形
            i1 = (int)f1;//整形存浮点会精度丢失
            Console.WriteLine(i1);
            f1 = (float)i1;//浮点存整形肯定没问题
            Console.WriteLine(f1);

            //char和数值类型
            i2 = 'a';
            char c = (char)i2;//对应ASCII码转字符，来回都能转
            Console.WriteLine(c);
            f1 = 97.2f;
            c = (char)f1;//char存浮点数，会自动舍去小数位后映射到ASCII码
            Console.WriteLine(c);

            //bool 和 string 都不能通过括号强转
            bool bo1 = true;
            //  i1 = (int)bo1;//报错
            string str1 = "123";
            // i1 = (int)str1;//报错


        #endregion

```

#### 2.2 Parse 法

目标类型.Parse(字符串)

```csharp
        #region 显式转换————Parse法
        //作用： 把string转换成其他类型（前面有提到，string不能括号强转）
        //语法： 目标类型.Parse(string类型变量名)  
        //      目标类型.Parse("字符串")
        //注意：字符串必须能够转换成对应类型才行，否则会报错

        //整形
  
        int i4 = int.Parse("123");
        Console.WriteLine(i4);

        //i4 = int.Parse("123.45"); //异常了，报错，编译不通过
        //Console.WriteLine(i4); 

        // short s4 = short.Parse("6666666"); //超出范围，报错
        // Console.WriteLine(s4);

        //浮点型 和上面一样

        // bool 字符串必须是true或false，否则会报错
        bool b5 = bool.Parse("true");
        Console.WriteLine(b5);
  
        // char  字符串必须是单个字符，否则会报错
        char c5 = char.Parse("a");
        Console.WriteLine(c5);



        #endregion

```

#### 2.3 Convert 法

Convert.To目标类型(源类型变量名/常量名)

```csharp
        #region 显式转换————Convert法
        //作用： 更准确地在各个类型之间转换
        //语法： Convert.To目标类型(源类型变量名/常量名)
        //      Convert.ToInt32()
        //      Convert.ToInt16() 相当于short
        //      Convert.ToInt64() 相当于long

        //      Convert.ToSingle() Single就是单精度，相当于float
        //      Convert.ToDouble() 相当于double
        //      Convert.ToDecimal() 相当于decimal

        //      Convert.ToSByte()
        //      Convert.ToByte()
        //      Convert.ToBoolean()
        //      Convert.ToChar()
        //      Convert.ToString()
        //注意： 填写的变量/常量必须是可以转换的类型，否则会报错
        //Conver.ToInt32(string)
        int i3 = Convert.ToInt32("123");
        Console.WriteLine(i3);
        //Conver.ToInt32(浮点数) 会四舍五入
        i3 = Convert.ToInt32(1.5f);
        Console.WriteLine(i3);
  
        //Conver.ToInt32(bool)
        i3 = Convert.ToInt32(true);
        Console.WriteLine(i3);
        i3 = Convert.ToInt32(false);
        Console.WriteLine(i3);

        //其他类型也能转
        bool b3 = Convert.ToBoolean(312);
        Console.WriteLine(b3);

        #endregion

```

#### 2.4 ToString()

*其他类型转成字符串*

源类型变量.toString()

```csharp
        #region 显式转换————其他类型转string
        //作用：拼接打印
        //语法： 源变量.ToString()

        string str3 = 1.ToString();
        Console.WriteLine(str3);

        string str4 = true.ToString();
        Console.WriteLine(str3);

        string str5 =  1.2f.ToString();
        Console.WriteLine(str3);

        //下面两个是等价的
        Console.WriteLine("1"+true+1.2f);//实际运行的时候自动调用toString()方法
        Console.WriteLine(str3+str4+str5);
  
        #endregion
  
```

> **题目：**

![1742292588337](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012754494-534879186.png)

4种：

括号强转 int i1 = (int)"123";

Parse法 i1 = int.Parse("123");

Convert法 i1 = Convert.ToInt32(1.2f);

ToString()法 string st1 = 1.ToString();

---

注意是转成字符，不是字符串

```csharp
//char只能隐式转换成其他大范围的类型，而不能隐式存放其他类型
        char c1 = (char)24069;
        Console.WriteLine(c1);

        c1 = Convert.ToChar(24069);
        Console.WriteLine(c1);
```

---

```csharp
        //题目3:
        Console.WriteLine("请按语文数学英语的顺序，输入三门成绩：");
        Console.WriteLine("输入语文成绩：");
        int chinese = Convert.ToInt32(Console.ReadLine());
        //或者：int chinese = int.Parse(Console.ReadLine());
        Console.WriteLine("输入数学成绩：");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("输入英语成绩：");
        int english = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Chinese: {0}\nMath: {1}\nEnglish: {2}",chinese,math,english);
        //或者：Console.WriteLine("Chinese:"+chinese+"\n"+"Math:"+math+"\n"+"English:"+english);  


  
```

## 异常捕获

```csharp
        #region 语法
        try{
            Console.WriteLine("请输入:");
            string str1 = Console.ReadLine();
            int i1 = int.Parse(str1);
            Console.WriteLine(i1);
        }
        catch{
            Console.WriteLine("你输入的不合法");
        }
        finally{
            Console.WriteLine("请输入合法数字!!!");
        }
        #endregion
```

> 练习题：
>
> ![1742896023720](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012754936-959448655.png)

```csharp
        try{
            Console.WriteLine("请输入一个数字:");
            string str2 = Console.ReadLine();
            int i2 = int.Parse(str2);
        }
        catch{
            Console.WriteLine("你输入的不合法");
        }
```

![1742896400053](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012755371-466042374.png)

```csharp
        try{
            Console.WriteLine("请输入姓名:");
            string str3 = Console.ReadLine();
            Console.WriteLine("请输入成绩1:");
            string str4 = Console.ReadLine();
            int i4 = int.Parse(str4);
            Console.WriteLine("姓名:" + str3 + " 成绩1:" + i4 + "\n");

        }
        catch{
            Console.WriteLine("你输入成绩1不合法");
        }

       try{
            Console.WriteLine("请输入成绩2:");
            string str5 = Console.ReadLine();
            int i5 = int.Parse(str5);
            Console.WriteLine(" 成绩2:" + i5 + "\n");

        }
        catch{
            Console.WriteLine("你输入成绩2不合法");
        }
```

![1742897083199](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012755737-2097934972.png)

可以知道哪一步不合法

## 运算符

### 算术运算符

#### 除法：/

整形的除法运算会丢失小数部分，要用浮点数存储要在运算时有浮点数特征，比如其中一个数加上f后缀⬇️

```csharp
float f = 1f / 2;
```

#### 取余数：%

整数和浮点数可以取余数，bool等其他类型不能

```csharp
        float a = 4.11f % 3.11f;
        Console.WriteLine(a);
```

#### 优先级

先乘除取余 后 加减

#### 自增自减

```csharp
        int a1 = 1, a2 = 1;
        //先用后变
        Console.WriteLine(a1++ +" "+ a2--);
  
        int a3 = 1, a4 = 1;
        //先变后用
        Console.WriteLine(++a3 +" "+ --a4);
```

![1742904116690](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012756165-1048443275.png)

> 练习题：
>
> ![1742904383178](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012756547-1954754991.png)

法1：中间商

```
int a = 1,b = 2;
int temp = a;
a = b;
b = temp;

```

法2：加减法（节省一个变量）

```csharp
int a = 1,b = 2;
a = a + b;
b = a - b;
a = a - b;
```

```csharp
        #region 练习题
        int seconds = 987652;
        int one_day = 60 * 60 * 24;
        int one_hour = 60 * 60;
        int one_minute = 60;
        int one_second = 1;
        Console.WriteLine(seconds/one_day+"天"+seconds%one_day/one_hour+"小时"+seconds%one_hour/one_minute+"分"+seconds%one_minute+"秒");
        #endregion

```

### 字符串拼接

#### 只用+和+=

```csharp
        #region 字符串拼接
        string str3 = "1";
        str3 += "2";
        Console.WriteLine(str3);
        str3 += 1;
        Console.WriteLine(str3);
        str3 += 1 + 2;
        Console.WriteLine(str3);
        str3 += "" + 3 ;
        Console.WriteLine(str3);


        #endregion
```

![1742959988918](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012756915-756551409.png)

```csharp
        str3 = "";
        str3 += 1 + 2 + "" + 2 + 3;
        Console.WriteLine(str3);
```

![1742960137858](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012757246-1565794629.png)

先计算""前面的，再和""以及后面的拼接

#### string.Format()

string.Format("待拼接的内容",内容0,内容1, ...);

```csharp
        #region 拼接法2
        //语法：string.Format("格式化字符串",参数1,参数2,参数3...)
        //格式化字符串里想要拼接的内容用占位符{i}替代，从0开始依次往后
        string str4 = string.Format("我是{0},今年{1}岁,身高{2}cm","sb",18,180);
        Console.WriteLine(str4);
        #endregion 
```

#### 控制台打印拼接

```csharp
        #region 控制台打印拼接
        Console.WriteLine("我是{0},今年{1}岁,身高{2}cm", "sb", 18, 180);
        #endregion
```

注意：后面的内容0,1,...可以多填(只是不拼接)，但不能少填(会报错)

### 条件运算符

特殊类型char string bool只能同类型== 或 !=

char可以和自己或数值类型比较（ascii码）

### 逻辑运算符

```csharp
            #region 逻辑与 &&
            bool result1 = true && false;
            Console.WriteLine(result1); // false
            #endregion

            #region 逻辑或 ||
            bool result2 = true || false;
            Console.WriteLine(result2); // true
            #endregion
  
            #region 逻辑非 !
            bool result3 = !true;
            Console.WriteLine(result3); // false
            #endregion
```

优先级：! > 算数运算符 > && > ||

#### 逻辑运算符短路规则

```csharp
            #region 短路规则
            int i3 = 1;
            bool result = i3 > 0 || ++i3 >0;
            Console.WriteLine(i3); // 1
            result = i3 < 0 && ++i3 >0;
            Console.WriteLine(i3); // 1
            #endregion
```

||是有真则真，如果左边就是真，就跳过后面。

&&是有假则假，如果左边就是假，就跳过后面。

### 位运算符

按位与&，按位或|，按位取反~，异或^，左移<<，右移>>

也就是换成二进制后进行位运算，最后结果再转回十进制

**异或^**：不同为1，相同为0

```csharp
Console.WriteLine(1 ^ 5);
// 001
//^101
// 100 结果4
```

**按位取反~**

补码和原码是互逆的，操作都是反码+1

反码：负数除符号位按位取反，正数不变

```csharp
        #region 位运算符
        // 位取反 ^
        int a = 5;
        // 0000 0000 0000 0000 0101
        // 1111 1111 1111 1111 1010 这样按位取反得到的是补码，还需要找到其原码
        // 1000 0000 0000 0000 0101 + 1
        // 1000 0000 0000 0000 0110 而最高位符号位是1，所以是-6
        Console.WriteLine(~a); // -6
        #endregion
```

**按位左移右移<<      >>**

左移几位 右侧加几个0

右移几位 右侧去掉几个数

### 三目运算符

 条件语句 ? 条件为真返回内容1 : 条件为假返回内容2;

注意：和c语言不一样的地方

三目运算符有返回值，必须使用(也就是必须赋值给变量)

返回值的类型必须一致

```csharp
        #region 三目运算符
        string str4 = (1>0)?"大于0":"小于等于0";
        Console.WriteLine(str4); // 大于0
        // str4 = (1>0)?"大于0":1; 错误，返回值类型不统一

        #endregion
```

### if语句

> 习题
>
> ![1742998075138](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012757661-1768738235.png)

![1742998151424](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012758051-194076075.png)

打印语句写进if里面或者在if前面定义b才行，因为b这个变量是在if里面定义的

### switch语句

```csharp
        // switch(变量){
        //     case 值1:
        //         //变量==值1则执行代码块1;
        //         break;
        //     case 值2:
        //         //变量==值2则执行代码块2;
        //         break;
        //     default:
        //         //默认代码块;
        //         break;
        // }
```

注意：switch语句中的值1,2,...必须是常量，不能条件语句

#### 可以自定义常量

用const自定义常量，然后把这个常量名放在值1,2,...中

```csharp
        char c = 'a';
        const char c2 = 'a';
        switch(c)   // switch语句
        {
            case c2:
                Console.WriteLine("c等于c2");
                break;
        }
```

#### 贯穿

如果某几个case所要执行的语句一样，可以只在最后一个case中写即可

```csharp
        int c = 0;
        switch(c)   // switch语句
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("哈哈哈");
                break;
            case 4:
                Console.WriteLine("呵呵呵");
                break;
            default:
                Console.WriteLine("啥也没有");
                break;
        }
```

注意：和c语言不同的地方

写一个case必须跟一个break，不能省略

### 循环语句

#### while

注意：

在每个循环体/if语句内定义的变量是局部变量，在外面不能使用，因此每个循环体内的变量之间没有关系，可以重复变量名，但最好不要这样做

##### 流程控制关键字：

break: 跳出while循环

continue: 跳回循环开始，也就是判断条件处继续执行

```csharp
        #region while
        // 流程控制关键字break和continue
        while(true){
            Console.WriteLine("break前");
            break;
            Console.WriteLine("break后");
        }
        Console.WriteLine("循环体外");
        #endregion
```

![1742999709665](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012758412-587764779.png)

注意break跳出的是while循环

但是嵌套语句里有for/switch的时候break是和for/switch配套的，这时候就不是跳出while了，但是continue是和while配套的

```csharp
        // 流程控制关键字break和continue
        int i = 0;
        while(true){
            ++i;
            Console.WriteLine(i);
            if(i==3){
                break;
            }
        }
        Console.WriteLine(i);
```

![1742999845822](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012758719-456928572.png)

```csharp
        while(true){
            Console.WriteLine("continue前");
            continue;
            Console.WriteLine("continue后");
        }
        Console.WriteLine("循环结束");
```

结果会一直输出"continue前"

> 题目

```csharp
        // 题目：打印1～20的奇数
        int i = 0;
        while(i <= 20){

            if(i % 2 == 1){
                Console.WriteLine(i);
                i+=2;
            }
            else{
                i++;
                continue;
            }
        }
```

> 题目
>
> 斐波那契数列第20个数

```csharp
        int first_num = 0, second_num=1, third_num=0, count=1;
        while(first_num<100000){
  
            third_num = first_num + second_num;
            first_num = second_num;
            second_num = third_num;
            Console.WriteLine(first_num);  
            count++;
            if(count == 20){
                Console.WriteLine("斐波那契数列的第20个数是："+third_num);
                break;
            }
        }
```

> 题目
>
> 100以内的素数

```csharp
        //题目：求100以内的素数
        int num = 2;
        while(num < 100){
            bool isPrime = true;
            for(int i = 2; i < num; i++){
                if(num % i == 0){
                    isPrime = false;
                    break;
                }
                else{
                    isPrime = true;
                }
            }
            if(isPrime) Console.WriteLine(num);
  
            num++;
        }
```

#### do while

先斩后奏，先执行一次循环体，再判断是否继续

注意：while后面有分号

```csharp
        //do while 循环
        do{
            Console.WriteLine("do while 循环");
        }while(false);
```

![1743003279753](https://img2023.cnblogs.com/blog/3614909/202503/3614909-20250327012759033-1317666335.png)

do while中的continue和break

continue是回到while的条件语句

```csharp
        //do while 循环
        do{
            Console.WriteLine("do while 循环");
            continue;
        }while(false);
```

结果和上面一样

#### for循环

continue和break的用法和while一样，所以需要注意配套使用，不能跨级使用

和while的区别：

for循环可以用来准确的到一个范围内的所有数

> 习题：
>
> 经典水仙花数

```csharp
        //水仙花
        int ge = 0, shi = 0, bai = 0, num = 0;

        for(; num <= 999; num++){
            bai = num / 100;
            shi = num % 100 / 10;
            ge = num % 10;
            if(num == ge * ge * ge + shi * shi * shi + bai * bai * bai){
                Console.WriteLine(num);
            }
        }
```

# C# 基础篇

> github仓库：[https://github.com/EanoJiang/CSharp_base]()

![1745502839126](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220248560-1327371337.png)

## 枚举(enum)

枚举是一个被命名的整形常量的集合

用于表示： 状态 类型

申明枚举：创建一个自定义的枚举类型

申明枚举变量：使用申明的自定义的枚举类型，来创建一个枚举变量

### 语法

```csharp
        //语法：枚举名 以E或E_开头，作为命名规范
        enum E_自定义枚举名{
            自定义枚举项名字1,//枚举中的第一个默认值是0，也可以赋值，下面依次累加。
            自定义枚举项名字2,//1
            自定义枚举项名字3,//2
        }
```

### 在哪里申明枚举

1. namespace语句块中
2. class语句块中
3. struct语句块中

枚举不能在函数语句块中声明

```csharp
        #region 在哪里申明枚举
        //namespace语句块中
        //class语句块中
        //struct语句块中
        //枚举不能再函数语句块中声明
        enum E_MonsterType{
            Normal,
            Boss,
        }
        enum E_PlayerType{
            Main,
            Other,
        }
        #endregion
```

![1745503523685](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220549353-1336886670.png)

### 枚举的用法

1. 申明枚举变量： **前面自定义的 变量名 = 默认值;**
2. 枚举和switch配套使用

```csharp
            #region 枚举的用法
            //申明枚举变量
            //前面自定义的 变量名 = 默认值;
            // (这里的默认值的格式：自定义的枚举类型.枚举项)枚举类型
            E_MonsterType monsterType = E_MonsterType.Normal;
            E_PlayerType playerType  = E_PlayerType.Main;
            if(playerType == E_PlayerType.Main){
                Console.WriteLine("主角的逻辑");
            }
            else if(playerType == E_PlayerType.Other){
                Console.WriteLine("其他角色的逻辑");
            }

            //枚举很适合和switch配套使用
            //也可以贯穿，两种情况使用同一个逻辑
            switch (monsterType){
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物的逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("BOSS的逻辑");
                    break;
            }
            #endregion

```

### 枚举的类型转换

```csharp
            #region 枚举的类型转换
            //枚举转int——括号强转
            int i1 = (int)playerType;
            Console.WriteLine(i1);
            //int 转枚举——隐式转换
            playerType = 0;
            Console.WriteLine(playerType);
  
            //枚举转string——ToString()方法
            string s1 = playerType.ToString();
            Console.WriteLine(s1);
            //string 转枚举——Parse()方法 + 自定义枚举类型括号强转
            //语法：(自定义枚举类型)Enum.Parse(typeof(自定义枚举类型), "要转换的字符串");
            //注意要转换的字符串必须是枚举里有的常量
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Main");
            Console.WriteLine(playerType);

            #endregion

```

> (总结)枚举的作用

在游戏开发中，对象通常会有很多状态

每个状态需要一个变量 / 标识 来表示，以便于后续使用时的判断(该对象当前处于什么状态)

不要去用int 表示他的状态 ，1走路	2空闲 3跑步 4跳跃

**枚举的使用可以很好的分清楚各状态的含义，提高代码可读性**

### 习题

![1743518617837](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220249258-2102536473.png)

```csharp
    /// <summary>
    /// 状态
    /// </summary>
    enum E_StateOnlineType{
        Offline,
        Online,
        Busy,
        Invisible,
    }
```

```csharp
        #region 题目1 用户状态
        try
        {
            Console.WriteLine("请输入状态(0-3):");
            E_StateOnlineType state = (E_StateOnlineType)Enum.Parse(typeof(E_StateOnlineType), Console.ReadLine());
            Console.WriteLine(state);
        }
        catch{
            Console.WriteLine("输入错误,请输入0-3的数字!");
        }
        #endregion
```

![1743518632428](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220249821-2103424914.png)

```csharp
    /// <summary>
    /// 咖啡类型
    /// </summary>
    enum E_CoffeeType{
        /// <summary>
        /// 中杯
        M,
        /// <summary>
        /// 大杯
        /// </summary>
        L,
        /// <summary>
        /// 特大杯
        /// </summary>
        XL,
    }
```

```csharp
        #region 题目2 coffee
        try{
            Console.WriteLine("请输入咖啡类型(M/L/XL):");
            E_CoffeeType coffeeType = (E_CoffeeType)Enum.Parse(typeof(E_CoffeeType), Console.ReadLine());
            switch(coffeeType){
                case E_CoffeeType.M:
                    Console.WriteLine("中杯咖啡");
                    break;
                case E_CoffeeType.L:
                    Console.WriteLine("大杯咖啡");
                    break;
                case E_CoffeeType.XL:
                    Console.WriteLine("特大杯咖啡");
                    break;
                default:
                    Console.WriteLine("输入错误!");
                    break;
            }
        }
        catch{
            Console.WriteLine("输入错误,请输入M/L/XL!");
        }
  
        #endregion
  
```

![1743518647292](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220250471-994033431.png)

```csharp

```

## 数组

### 一维数组(数组)

一维、多维、交错数组

```csharp
namespace 数组;

class Program
{
    static void Main(string[] args)
    {
        #region 数组声明
        //只声明数组名，不初始化
        //变量类型[] 数组名;
        int[] arr1;
        //声明并初始化数组的长度，元素默认值是0
        //变量类型[] 数组名 = new 变量类型[数组长度];
        int[] arr2 = new int[5];
        //声明并初始化数组的长度和元素值
        //变量类型[] 数组名 = new 变量类型[数组长度] {元素值1, 元素值2, 元素值3...};
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
        //声明并初始化数组的元素值，数组长度自动计算
        //变量类型[] 数组名 = new 变量类型[] {元素值1, 元素值2, 元素值3...};
        int[] arr4 = new int[] { 1, 2, 3, 4};
        //声明并初始化数组——最简单的方法
        int[] arr5 = { 1, 2, 3, 4, 5 };

        bool[] arr6 = new bool[] { true, false, true, false };

        #endregion
  
        #region 数组使用
        int[] arr = { 1, 2, 3, 4, 5 };
        //1. 获取数组长度
        //数组名.Length
        Console.WriteLine("数组长度：" + arr.Length);
        //2. 获取数组元素
        //数组名[索引]
        //注意不要越界
        Console.WriteLine("数组第一个元素：" + arr[0]);
        //3. 修改数组元素
        //数组名[索引] = 新值;
        arr[0] = 10;
        Console.WriteLine("修改后的数组第一个元素：" + arr[0]);
        //4. 遍历数组
        for(int i = 0; i < arr.Length; i++){
            Console.WriteLine("数组第" + i + "个元素：" + arr[i]);
        }
        //5. 增加数组元素(先拷贝数组)
        int[] array2 = new int[6];
        for(int i = 0; i < arr.Length; i++){
            array2[i] = arr[i];
        }
        arr = array2;
        arr[5] = 6;
        Console.WriteLine("增加后的数组：" + string.Join(",", arr));
        //6. 删除数组元素(先拷贝数组)
        int[] array3 = new int[4];
        for(int i = 0; i < 4; i++){
            array3[i] = arr[i];
        }
        arr = array3;
        Console.WriteLine("删除后的数组：" + string.Join(",", arr));
        //7. 查找数组元素
        int elem = 3;
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == elem){
                Console.WriteLine("元素" + elem + "在数组的索引为：" + i);
                break;
            }
        }
        #endregion
  
    }
}

```

用来批量存储游戏中同一类型的所有对象，比如所有的enemy和player

> 习题

![1744599979137](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220251154-1729745057.png)

```csharp
#region 1
int[] arr1 = new int[100];
for(int i = 0; i < arr1.Length; i++){
    arr1[i] = i;
}
Console.WriteLine(string.Join(",", arr1));
#endregion
```

```csharp
#region 2
int[] arr2 = new int[100];
for(int i = 0; i < arr2.Length; i++){
    arr2[i] = arr1[i] * 2;
}
Console.WriteLine(string.Join(",", arr2));
#endregion
```

```csharp
#region 3
Random r1 = new Random();
int[] arr3 = new int[10];
for(int i = 0; i < arr3.Length; i++){
    arr3[i] = r1.Next(0, 101);
}
Console.WriteLine(string.Join(",", arr3));
#endregion
```

```csharp
#region 4
Random r = new Random();
int[] arr = new int[10];
for(int i = 0; i < arr.Length; i++){
    arr[i] = r.Next(0, 101);
}
Console.WriteLine("原数组："+string.Join(",", arr));
//MAX MIN
int max = arr[0];
int min = arr[0];
int sum = 0;
for(int i = 0; i < arr.Length - 1; i++){
    max = (max >= arr[i])? max : arr[i];
    min = (min <= arr[i])? min : arr[i];
    sum += arr[i];
}
Console.WriteLine("最大值："+max);
Console.WriteLine("最小值："+min);
Console.WriteLine("和："+sum);
double avg = (double)sum / arr.Length;
Console.WriteLine("平均值："+avg);
#endregion

```

```csharp
#region 5
Random r2 = new Random();
int[] arr4 = new int[10];
for(int i = 0; i < arr4.Length; i++){
    arr4[i] = r2.Next(0, 101);
}
Console.WriteLine("原数组："+string.Join(",", arr4));
for(int i = 0; i < arr4.Length /2; i++){
    arr4[i] = arr4[i] + arr4[arr4.Length-1-i];
    arr4[arr4.Length-1-i] = arr4[i] - arr4[arr4.Length-1-i];
    arr4[i] = arr4[i] - arr4[arr4.Length-1-i];
}
Console.WriteLine("反转后："+string.Join(",", arr4));
#endregion
```

```csharp
#region 6
Random r3 = new Random();
int[] arr5 = new int[10];
for(int i = 0; i < arr5.Length; i++){
    arr5[i] = r3.Next(-100, 101);
}
Console.WriteLine("原数组："+string.Join(",", arr5));
for(int i = 0; i < arr5.Length; i++){
    if(arr5[i]>0) arr5[i]++;
    else if(arr5[i]<0) arr5[i]--;
}
Console.WriteLine("变化后："+string.Join(",", arr5));
#endregion
```

```csharp
#region 7
int[] arr6 = new int[10];
//输入
try{
    for(int i = 0; i < arr6.Length; i++){
        Console.Write("请输入第{0}个元素：", i+1);
        arr6[i] = Convert.ToInt32(Console.ReadLine());
    }
}
catch{
    Console.WriteLine("输入有误，程序退出");
}

Console.WriteLine("原数组："+string.Join(",", arr6));
//MAX MIN
int max = arr6[0];
int min = arr6[0];
int sum = 0;
for(int i = 0; i < arr6.Length - 1; i++){
    max = (max >= arr6[i])? max : arr6[i];
    min = (min <= arr6[i])? min : arr6[i];
    sum += arr6[i];
}
Console.WriteLine("最大值："+max);
Console.WriteLine("最小值："+min);
Console.WriteLine("平均值："+(double)sum / arr6.Length);

#endregion
```

```csharp
#region 8
string[] arr7 = new string[25];
for(int i = 0; i < arr7.Length; i++){
    arr7[i] = (i%2 == 0)? "■": "□";
}
for(int i = 0; i < arr7.Length; i++){
    Console.Write(arr7[i]);
    if((i+1)%5 == 0 && i!= 0){
        Console.WriteLine();
    }

}
#endregion
```

### 二维数组

```csharp
namespace 二维数组;

class Program
{
    static void Main(string[] args)
    {
        #region 二维数组的申明
        //申明但不初始化：
        //变量类型[,] 二维数组变量名
        int[,] arr1;
        //变量类型[,] 二维数组变量名 = new int[行数,列数];
        int[,] arr2 = new int[3, 3];
        //申明+初始化：
        //变量类型[,] 二维数组变量名 = new int[行数,列数] { {元素1,元素2,元素3...}, {元素1,元素2,元素3...},... };
        int[,] arr3 = new int[3, 3] {   { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 }};

        //行列自动计算
        int[,] arr4 = new int[,] {   { 1, 2, 3 },
                                     { 4, 5, 6 },
                                     { 7, 8, 9 }};
        #endregion 

        #region 二维数组的使用
        //1.二维数组的长度
        int[,] array1 = new int[,]{ {1,2,3},
                                    {4,5,6},
                                    {7,8,9}};
        //二维数组名.GetLength(dimesion)，dimesion为0表示行，为1表示列
        //行
        Console.WriteLine(array1.GetLength(0));
        //列
        Console.WriteLine(array1.GetLength(1));

        //2.获取二维数组的元素
        //二维数组名[行,列]
        Console.WriteLine(array1[0, 0]);

        //3.修改二维数组的元素
        //二维数组名[行,列] = 元素值
        array1[0, 0] = 10;
        Console.WriteLine(array1[0, 0]);

        //4.遍历二维数组
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("**************");
        //5.增加数组元素
        int[,] array2 = new int[4,3];
        //先拷贝原数组元素
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array2[i, j] = array1[i, j];
            }
        }
        array1 = array2;
        array1[3, 0] = 100;
        array1[3, 1] = 101;
        array1[3, 2] = 102;
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************");
        //6.删除数组元素
        //先拷贝原数组元素
        int[,] array3 = new int[2, 3];
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = array1[i, j];
            }
        }
        array1 = array3;
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }
  
        //7.查找数组元素
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                if(array1[i,j] == 6)
                {
                    Console.WriteLine("元素6的位置为：{0},{1}", i, j);
                }
            }
        }   
        #endregion

    }
}

```

> 习题

![1745197894081](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220251879-73345685.png)

```csharp
#region 1
int[,] arr1 = new int[100, 100];
int count = 1;
Console.WriteLine("1到10000的二维数组：");
for (int i = 0; i < arr1.GetLength(0); i++){
    for (int j = 0; j < arr1.GetLength(1); j++){
        arr1[i, j] = count;
        count++;
        Console.Write(arr1[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion
```

```csharp
#region 2
int[,] arr2 = new int[4, 4];
Random r = new Random();
Console.WriteLine("随机生成的4x4二维数组：");
for (int i = 0; i < arr2.GetLength(0); i++){
    for (int j = 0; j < arr2.GetLength(1); j++){
        arr2[i, j] = r.Next(1, 101);
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("将数组的右上角区域清零：");
for (int i = 0; i < arr2.GetLength(0); i++){
    for (int j = 0; j < arr2.GetLength(1); j++){
        if(i < arr2.GetLength(0) / 2 && j >= arr2.GetLength(1) / 2){
            arr2[i, j] = 0;
        }
        Console.Write(arr2[i, j] + " ");
    }
    Console.WriteLine();
}
#endregion

```

```csharp
#region 3
int[,] arr3 = new int[3, 3];
Random r = new Random();
Console.WriteLine("随机生成的3x3二维数组：");
for (int i = 0; i < arr3.GetLength(0); i++){
    for (int j = 0; j < arr3.GetLength(1); j++){
        arr3[i, j] = r.Next(1, 11);
        Console.Write(arr3[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("对角线:");
int sum = 0;
for (int i = 0; i < arr3.GetLength(0); i++){
    for (int j = 0; j < arr3.GetLength(1); j++){
        if(i == j || i+j == 3-1){
            sum += arr3[i, j];
            Console.Write(arr3[i, j] + " ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("对角线的和为：" + sum);


#endregion
```

```csharp
#region 4
int[,] arr4 = new int[5, 5];
Random r = new Random();
//记录最大值的位置
int maxRow = 0, maxCol = 0;
Console.WriteLine("随机生成的5x5二维数组：");
for (int i = 0; i < arr4.GetLength(0); i++){
    for (int j = 0; j < arr4.GetLength(1); j++){
        arr4[i, j] = r.Next(1, 11);
        Console.Write(arr4[i, j] + " ");
        if(arr4[maxRow, maxCol] < arr4[i, j]){
            maxRow = i;
            maxCol = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("最大值{0}的位置：({1},{2})" , arr4[maxRow, maxCol], maxRow, maxCol);

Console.WriteLine("****所有最大值元素{0}的位置****");
for(int i = 0; i < arr4.GetLength(0); i++){
    for(int j = 0; j < arr4.GetLength(1); j++){
        if(arr4[i,j] == arr4[maxRow, maxCol]){
        Console.WriteLine("最大值{0}的位置：({1},{2})" , arr4[maxRow, maxCol], i, j);
        }
    }
}

#endregion
```

```csharp
#region 5
int[,] arr5 = new int[5, 5] {   { 0,0,0,0,0},
                                { 0,0,0,0,0},
                                { 0,0,1,1,0},
                                { 0,0,0,0,0},
                                { 0,0,0,0,0}};

void transArray(int[,] arr){
    //用来记录行和列是否有1的真值数组
    bool[] boolRow = new bool[arr.GetLength(0)];
    bool[] boolCol = new bool[arr.GetLength(1)];
    //标记行和列
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if(arr[i,j] == 1){
                boolRow[i] = true;
                boolCol[j] = true;
            }
        }
    }
    //转置
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if(boolRow[i] == true || boolCol[j] == true){
                arr[i,j] = 1;
            }
        }
    }
}
transArray(arr5);
Console.WriteLine("转置后的数组：");
for (int i = 0; i < arr5.GetLength(0); i++){
    for (int j = 0; j < arr5.GetLength(1); j++){
        Console.Write(arr5[i, j] + " ");
    }
    Console.WriteLine();
}

#endregion
```

### 交错数组

数组的数组

特点：存储 确定行数，不确定列数的数据

```csharp
namespace 交错数组;

class Program
{
    static void Main(string[] args)
    {
        #region 交错数组的申明
        //只申明
        //变量类型[][] 交错数组名;
        int[][] arr1;

        //申明+初始化
        //变量类型[][] 交错数组名 = new int[行数][];
        int[][] arr2 = new int[3][];
        //变量类型[][] 交错数组名 = new int[行数][] { 一维数组1, 一维数组2, 一维数组3 };
        //注意：{一维数组的数据类型要和交错数组的类型一致}
        int[][] arr3 = new int[3][] {   new int[] { 1, 2 }, 
                                        new int[] { 3, 4}, 
                                        new int[] { 5 } };
        //变量类型[][] 交错数组名 = new int[][] { 一维数组1, 一维数组2, 一维数组3 };
        int[][] arr4 = new int[][] {    new int[] { 1, 2 }, 
                                        new int[] { 3, 4}, 
                                        new int[] { 5 } };
  
        //最常用：
        //变量类型[][] 交错数组名 = { 一维数组1, 一维数组2, 一维数组3 };
        int[][] arr5 = {new int[] {1, 2, 3},
                        new int[] {4, 5},
                        new int[] {6, 7, 8, 9}};
        #endregion
  
        #region 交错数组的使用
        int[][] array1 = {  new int[] {1, 2, 3},
                            new int[] {4, 5}    };
        //1.数组的长度
        //行
        //交错数组名.Length
        //交错数组名.GetLength(0)
        Console.WriteLine(array1.Length);
        Console.WriteLine(array1.GetLength(0));
        //列
        //交错数组名[行].Length
        //其实就是找到交错数组中的某个一维数组的长度
        Console.WriteLine(array1[0].Length);
        Console.WriteLine(array1[1].Length);

        //2.获取交错数组的元素
        //交错数组名[行][列]
        Console.WriteLine(array1[0][0]);

        //3.修改交错数组的元素
        //交错数组名[行][列] = 值;
        array1[0][0] = 10;
        Console.WriteLine(array1[0][0]);

        //4.遍历交错数组
        //和二维数组一样，只不过是遍历每一个一维数组
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array1[i].Length; j++)
            {
                Console.Write(array1[i][j] + " ");
            }
            Console.WriteLine();
        }

        //5.增加交错数组的元素
        //6.删除交错数组的元素
        //7.查找交错数组的元素
        //***都和二维数组一样***
        #endregion
    }

}

```

## 值类型和引用类型

> 引用类型：string、数组、(class)类

> 值类型：其他数据类型，结构体

![1747985397976](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250523153039396-1829202687.png)

区别：

值类型：在相互赋值的时候把内容拷贝给对方，一个变另一个不会变

引用类型：两者指向同一个值，一个变另一个也变

```csharp
namespace 值类型和引用类型;

class Program
{
    static void Main(string[] args)
    {
        //值类型
        int a = 1;
        //引用类型
        int[] arr = new int[] {1,2,3,4 };

        //赋值给另一个变量
        int b = a;
        int[] arr2 = arr;
        Console.WriteLine("a={0},b={1}\narr[0]={2},arr2[0]={3}",a,b,arr[0],arr2[0]);
  
        //修改新的变量
        b = 2;
        arr2[0] = 99;
        Console.WriteLine("a={0},b={1}\narr[0]={2},arr2[0]={3}",a,b,arr[0],arr2[0]);
    }
}

```

> WHY？

值类型存储在栈空间——系统分配，自动回收，小而快

引用类型存储在堆空间——手动申请释放，大而慢

![1745215518430](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220252511-876279679.png)

值类型每次申明相当于开了一个栈空间，赋值的时候互不影响。

引用类型申明的时候开的栈空间存放的是一个指针(地址)，指向一块堆内存，赋值的时候其实赋的是地址。

> 习题

![1745215752082](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220253076-1656417719.png)

* 10
* 20
* "123"

### string——特殊的引用类型

每次重新赋值的时候在堆内存重新分配空间，地址也会重新分配

```csharp
        #region string——特殊的引用类型
        string str1 = "123";
        string str2 = str1;//这一步两个变量指向的地址相同

        str2 = "456";//str2重新赋值，地址改变
        Console.WriteLine("str1={0},str2={1}",str1,str2);
        #endregion
```

> 习题

```csharp
        #region 习题
        int[] arr3 = new int[]{1};
        int[] arr4 = arr3;
        int[] arr5 = arr3;
        arr4[0] = 99;//arr4修改单个元素，地址不变
        arr5 = new int[5];//arr5重新赋值，地址改变，指向新的堆内存
        Console.WriteLine("arr3[0]={0},arr4[0]={1},arr5[0]={2}",arr3[0],arr4[0],arr5[0]);
        #endregion
```

### 总结

只要是整体重新赋值（像new int[]）地址就会改变

而单独改一个元素，地址不会改变

## 函数(方法)

### 函数基础

> 作用：

1. 封装代码
2. 提高代码复用率
3. 抽象行为

> 写在哪儿？

1. class(类)语句块中
2. struct(结构体)语句块中

#### 语法

```csharp
namespace 函数;

class Program
{
    #region 函数的语法
    // static 返回类型 函数名(参数类型 参数名){
    //     // 函数体
    //     return 返回值;
    // }
    #endregion
    static void Main(string[] args)
    {

    }
}

```

1. 在学习类和结构体之前，static必须写
2. 函数名用帕斯卡命名法，比如：MyName()
3. 参数名用驼峰命名法
4. 即使函数返回类型是void，也可以选择性使用return

#### 使用

```csharp
namespace 函数;

class Program
{
    //有参有返回值的函数
    static int[] sum_avg(int a, int b)
    {
        int sum = a + b;
        int avg = sum / 2;
        // int[] result = { sum, avg };
        return new int[] { sum, avg };
    }

    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int[] result = sum_avg(a, b);
        Console.WriteLine("The sum is: " + result[0]);
        Console.WriteLine("The average is: " + result[1]);

    }
}

```

#### 关于return

```csharp
    static void Say(string str){
        //void也是可以写return的，return后面的语句不会执行
        if(str == "Fuck") return;
        Console.WriteLine(str);
    }
```

> 习题

![1745332909897](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220253629-1019468544.png)

```csharp
    #region 1
    static int Max(int a, int b){
        return (a > b)? a : b;
    }
    #endregion
```

```csharp
    #region 2
    static float[] Circle(float r){
        //1
        // float area  = 3.14f * r * r;
        // float perimeter = 2 * 3.14f * r;
        // float[] result = {area, perimeter};
        // return result;
        //2
        return new float[] { 3.14f * r * r, 2 * 3.14f * r };
    }
    #endregion

```

```csharp
    #region 3
    static int[] CalculateArr(int[] arr){
        if( arr.Length == 0 )
        {
            Console.WriteLine("数组不能为空");
            return new int[0];
        }
        int sum = 0, max = arr[0], min = arr[0], average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            max = (max >= arr[i]) ? max : arr[i];
            min = (min <= arr[i]) ? min : arr[i];
        }
        average = sum / arr.Length;
        int[] result = { sum, max, min, average };
        return result;
    }
    #endregion

```

```csharp
    #region 4
    static bool IsPrime(int num){
        for(int i = 2; i <= num; i++){
            if(num%i == 0) return false;
        }
        return true;
    }
    #endregion

```

```csharp
    #region 5
    static bool IsLeapYear(int year){
        if(year%4 == 0 && year%100!= 0 || year%400 == 0) return true;
        //默认返回false
        return false;
    }
    #endregion

```

### ref和out

#### 为什么要学这个？

```csharp
namespace ref和out;

class Program
{
    #region 为什么要学习ref和out？
    //正常来说，我们在调用函数的时候，传递的是值，函数内部修改这个值，并不会影响到外部的变量。
    //只有当传入参数是引用类型且引用类型没有被重新赋值时，才会影响到外部的变量。
    static void ChangeValue(int value){
        value = 1;
    }

    static void ChangeArrValue(int[] arr){
        arr[0] = 1;
    }

    static void ChangeArr(int[] arr){
        arr = new int[]{1};
    }
    #endregion
    static void Main(string[] args)
    {
        int value = 0;
        //传入函数的只是这个变量，没有返回，所以值不变
        ChangeValue(value);
        Console.WriteLine(value); // Output: 0


        int[] arr1 = new int[1];
        //传入函数的是arr的地址，arr和arr1都指向arr1的地址，所以值会变
        ChangeArrValue(arr1);
        Console.WriteLine(arr1[0]); // Output: 1
  
        int[] arr2 = new int[1];
        //因为函数ChangeArr中arr新开辟了一个地址，与传入的数组的地址不再有关联，所以值不变
        ChangeArr(arr2);
        Console.WriteLine(arr2[0]); // Output: 0
  
    }
}

```

> 正常来说，我们在调用函数的时候，传递的是值，函数内部修改这个值，并不会影响到外部的变量。
>
> 只有当传入参数是引用类型且引用类型没有被重新赋值时，才会影响到外部的变量。

**ref和out用来实现：** 当传入参数在函数内修改时，外部也发生变化

#### 使用

函数参数的修饰符，比如 `ChangeValueRef( ref int value )`

```csharp
namespace ref和out;

class Program
{
    #region 为什么要学习ref和out？
    //正常来说，我们在调用函数的时候，传递的是值，函数内部修改这个值，并不会影响到外部的变量。
    //只有当传入参数是引用类型且引用类型没有被重新赋值时，才会影响到外部的变量。
    static void ChangeValue(int value){
        value = 1;
    }
    static void ChangeArrValue(int[] arr){
        arr[0] = 1;
    }
    static void ChangeArr(int[] arr){
        arr = new int[]{1};
    }
    #endregion

    #region ref和out的使用
    //ref
    static void ChangeValueRef(ref int value){
        value = 1;
    }
    static void ChangeArrRef(ref int[] arr){
        arr = new int[]{1};
    }

    //out
    static void ChangeValueOut(out int value){
        value = 2;
    }
    static void ChangeArrOut(out int[] arr){
        arr = new int[]{2};
    }

    #endregion
    static void Main(string[] args)
    {
        int value = 0;
        //传入函数的只是这个变量，没有返回，所以值不变
        ChangeValue(value);
        Console.WriteLine("正常传入参数,值不变: "+value); // Output: 0

        ChangeValueRef(ref value);
        Console.WriteLine("加了ref关键字,值变了: "+value); // Output: 1
        ChangeValueOut(out value);
        Console.WriteLine("加了out关键字,值变了: "+value); // Output: 2

        int[] arr1 = new int[1];
        //传入函数的是arr的地址，arr和arr1都指向arr1的地址，所以值会变
        ChangeArrValue(arr1);
        Console.WriteLine(arr1[0]); // Output: 1
  

        int[] arr2 = new int[1];
        //因为函数ChangeArr中arr新开辟了一个地址，与传入的数组的地址不再有关联，所以值不变
        ChangeArr(arr2);
        Console.WriteLine("正常传入参数,值不变: "+arr2[0]); // Output: 0
        ChangeArrRef(ref arr2);
        Console.WriteLine("加了ref关键字,值变了: "+arr2[0]); // Output: 1
        ChangeArrOut(out arr2);
        Console.WriteLine("加了out关键字,值变了: "+arr2[0]); // Output: 2

    }
}

```

#### 区别

ref传入的变量必须初始化，所以在函数内部就可以不赋值

out传入的变量可以不初始化，所以在函数内部必须赋值

```csharp
namespace ref和out;

class Program
{
    #region ref和out的使用
    //ref
    static void ChangeValueRef(ref int value){
        value = 1;
    }
    static void ChangeArrRef(ref int[] arr){
        arr = new int[]{1};
    }
    static void ChangeValueRef2(ref int value){
        // value = 1;
    }

    //out
    static void ChangeValueOut(out int value){
        value = 2;
    }
    static void ChangeArrOut(out int[] arr){
        arr = new int[]{2};
    }
    // 报错，因为out修饰的传入变量必须在函数内部赋值，ref不需要
    // static void ChangeValueOut2(out int value){
    //     // value = 2;
    // }

    #endregion
  

    static void Main(string[] args)
    {
        #region ref和out的区别
        //ref修饰的传入变量必须初始化，out不需要
        //out修饰的传入变量必须在函数内部赋值，ref不需要
        int value;
        // ChangeValueRef(ref value);   报错
        ChangeValueOut(out value);

        //其实总的来看，
        // ref传入的变量必须初始化，所以在函数内部就可以不赋值
        // out传入的变量可以不初始化，所以在函数内部必须赋值
  
        #endregion
    }
}

```

> 习题

![1745339458522](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220254310-1517787006.png)

```csharp
// See https://aka.ms/new-console-template for more information

static bool CheckLogin(string username, string password, out string message)
{
    message = "";
    if (username == "eano")
    {
        if(password == "666"){
            message = "Login successful";
            return true;
        }
        else{
            message = "Invalid password";
            return false;
        }

    }
    else
    {
        message = "Invalid username";
        return false;
    }
}

string message;

Console.WriteLine("请输入正确的用户名:");
string adminUsername = Console.ReadLine();
Console.WriteLine("请输入正确的密码:");
string adminPassword = Console.ReadLine();
while(CheckLogin(adminUsername, adminPassword, out message)== false){
    // 输出上一次的错误信息
    Console.WriteLine(message);
    Console.WriteLine("请输入正确的用户名:");
    adminUsername = Console.ReadLine();
    Console.WriteLine("请输入正确的密码:");
    adminPassword = Console.ReadLine();
}
Console.WriteLine(message);


```

### 变长参数和参数默认值

*变长参数不能和ref/out 一起用*

#### 变长参数

```csharp
#region 变长参数   
//修饰参数关键字 params 
//params后面必须是数组,所以只能是同一类型的可变参数
//参数最多只能出现一个params关键字,且一定是最后一组参数
static int Sum(params int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    return sum;
}
#endregion

Console.WriteLine(Sum(1, 2, 3, 4, 5)); // 15

```

#### 参数默认值

*ref和out不能有参数默认值*

```csharp
#region 参数默认值(可选参数)
//每个参数都可以有一个默认值
//混用的时候，可选参数要写在必选参数后面
static void Say(string str = "Hello"){
    Console.WriteLine(str);
}
static void Say2(string str, string name = "World"){
    Console.WriteLine(str + " " + name);
}
#endregion

//不传入参数时,默认使用参数默认值
Say(); // Hello
//传入参数时,使用传入的参数值
Say("World"); // World
Say2("Hello"); // Hello World
```

> 习题

![1745367794256](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220254967-139674506.png)

```csharp
#region 1
static int[] Calculate(params int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    int average = sum / numbers.Length;
    return new int[] {sum, average};
}
#endregion

#region 2
static int[] Sum_Odd_Even(params int[] numbers){
    int sum_odd = 0;
    int sum_even = 0;
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] % 2 == 0){
            sum_even += numbers[i];
        }
        else{
            sum_odd += numbers[i];
        }
    }
    return new int[] {sum_odd, sum_even};
}
#endregion

int[] result = Calculate(1, 2, 3, 4, 5);
Console.WriteLine("Sum: " + result[0]);
Console.WriteLine("Average: " + result[1]);

int[] result2 = Sum_Odd_Even(1, 2, 3, 4, 5);
Console.WriteLine("Sum of odd numbers: " + result2[0]);
Console.WriteLine("Sum of even numbers: " + result2[1]);
```

### 函数重载

函数名相同、参数的数量不同 (或 参数的数量相同，但参数的类型、顺序不同)的一组函数

作用：

1. 用来命名一组功能相似的函数(不同参数的同一逻辑处理)，减少函数名的数量，避免命名空间的污染
2. 提高程序可读性

```csharp
namespace 函数重载;

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    //参数的数量不同
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    //参数的类型不同
    static double Sum(double a, double b)
    {
        return a + b;
    }
    //参数的顺序不同(其实也是类型不同)
    static float Sum(float a, int b){
        return a + b;
    }

    //参数用ref out 修饰
    //out传入的参数必须要在函数内部赋值
    static int Sum(ref int a,out int b)
    {
        b = 1;
        return a + b;
    }

    //参数是可变参数
    static int Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

  
    static void Main(string[] args)
    {
        Sum(1, 2);
        Sum(1, 2, 3);
        Sum(1.0, 2.0);
        Sum(1.0f, 2);
        int a = 1;
        int b;
        Sum(ref a, out b);
    }
}

```

> 习题

![1745371144198](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220255575-530650026.png)

```csharp
namespace 函数重载习题;

public class Program{  
    #region 1
    static int Max(int a, int b){
        return a > b? a : b;
    }
    static double Max(double a, double b){
        return a > b? a : b;
    }
    #endregion
    #region 2
    static int Max(params int[] numbers){
        int max = numbers[0];
        for(int i = 0; i < numbers.Length; i++){
            max = (numbers[i] > max)? numbers[i] : max;
        }
        return max;
    }
    static double Max(params double[] numbers){
        double max = numbers[0];
        for(int i = 0; i < numbers.Length; i++){
            max = (numbers[i] > max)? numbers[i] : max;
        }
        return max;
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine(Max(1, 2));
        Console.WriteLine(Max(1.0, 2.0));

        Console.WriteLine(Max(1, 2, 3, 4, 5));
        Console.WriteLine(Max(1.0, 2.0, 3.0, 4.0, 5.0));
    }

}

```

### 递归

必须有结束掉用的条件

```csharp
static void Fun(int n0 = 1,int n1 = 10){
    if(n1 < n0)return;
    Console.WriteLine(n1);
    n1--;
    Fun(n0,n1);
}
Fun(1,10);

```

> 习题

![1745374178441](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220256146-2058828517.png)

```csharp
#region 1
static void PrintNum(int n0, int n1){
    if(n1 < n0){
        return;
    }
    Console.WriteLine(n1);
    // n1--;
    //这里要用前缀--n1，先减后用，不然会出现无限递归导致栈溢出
    PrintNum(n0, --n1);
}
#endregion

#region 2
static int Factorial(int n){
    if(n == 1) return n;
    return n * Factorial(n-1);
        // 5 * Fun2(4) = 5 * 4 * 3 * 2 * 1
        // 4 * Fun2(3) = 4 * 3 * 2 * 1
        // 3 * Fun2(2) = 3 * 2 * 1
        // 2 * Fun2(1) = 2 * 1
        // 1
}
#endregion

#region 3
static int SumOfFactorial(int n){
    if(n == 1) return Factorial(n);
    return Factorial(n) + SumOfFactorial(n-1);
}
#endregion

#region 4
static float getFinalLength(float length,int days){
    //从第0天开始，所以days要+1
    if(days+1 == 0) return length;
    //这里要用前缀--days，先减后用，不然会出现无限递归导致栈溢出
    return getFinalLength(length/2.0f,--days);
}
#endregion

#region 5
static bool PrintNum2(int n0, int n1){
    // if(n1 < n0){
    //     return;
    // }
    Console.WriteLine(n1);
    // n1--;
    //这里要用前缀--n1，先减后用，不然会出现无限递归导致栈溢出
    return n1 < n0 || PrintNum2(n0, --n1);
}
#endregion

PrintNum(0, 10);
Console.WriteLine("阶乘5= "+Factorial(5));
Console.WriteLine("!1 + ... + !10 = "+SumOfFactorial(10));
Console.WriteLine("100 的最终长度为: "+getFinalLength(100, 10));
PrintNum(0, 200);
```

## 结构体

结构体相当于一个人，他的变量相当于人的各个属性，方法相当于人的各个功能函数

### 语法

1. 写在namespace语句块中
2. 关键字struct
3. 帕斯卡命名法

```csharp
    struct 结构体名{
        //1. 变量
        int 变量名;
        //2. 构造函数
        结构体名(int 变量名){
            this.变量名 = 变量名;
        }
        //3. 方法
        void 方法名(){
            //...
        }
    }
```

### 访问修饰符

修饰结构体中的变量和方法 是否能被外部使用

> public 可以被外部访问
>
> private 只能在内部使用

默认不写，就是private

### 结构体的构造函数

1. 没有返回值
2. 函数名和结构体名相同
3. 必须有参数
4. 如果申明了构造函数，那就必须在其中对**所有**变量数据初始化

### 使用

```csharp
namespace 结构体;

class Program
{
    #region 语法
    // struct 结构体名{
    //     //1. 变量
    //     int 变量名;
    //     //2. 构造函数
    //     结构体名(int 变量名){
    //         this.变量名 = 变量名;
    //     }
    //     //3. 方法
    //     void 方法名(){
    //         //...
    //     }
    // }
    #endregion

    #region 示例
    struct Student{
        //1. 变量
        //结构体申明的变量 不能直接在结构体里面初始化
        //变量类型任意，包括结构体类型，但是只能是其他结构体类型，不能是自身结构体类型
        public int age;
        public bool sex; //true表示男性，false表示女性
        public string name;
        public Teacher teacher1;
        // Student student1;     //错误，不能是自身结构体类型

        //2. 构造函数
        //用于在外部初始化结构体变量
        public Student(int age, bool sex, string name, Teacher teacher1){
            this.age = age;
            this.sex = sex;
            this.name = name;
            this.teacher1 = teacher1;
        }
        //3. 方法
        //用来表现这个数据结构的行为，在结构体中不需要加static关键字
        //函数中可以直接使用结构体申明的变量
        public void Speak(){
            Console.WriteLine("Hi, my name is {0}, I am {1} years old.", name, age);
        }
    }
    struct Teacher{

    }
    #endregion

    static void Main(string[] args)
    {
        #region 结构体的使用
        Student s1;
        s1.age = 20;
        s1.sex = true;
        s1.name = "Tom";
        s1.Speak();

        //用构造函数的方式初始化结构体变量
        Student s2 = new Student(25, false, "Jerry", new Teacher());
        s2.Speak();
  
        #endregion
  
    }
}

```

> 习题

![1745383804457](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220256779-1026461466.png)

```csharp
namespace 结构体习题
{

    class Program
    {
        #region 1
        struct Student{
        public string name;
        public int age;
        public bool isMale;
        public int classNum;
        public string subject;
        public Student(string name, int age, bool isMale, int classNum, string subject){
            this.name = name;
            this.age = age;
            this.isMale = isMale;
            this.classNum = classNum;
            this.subject = subject;
        }
        public void PrintInfo(){
            Console.WriteLine("Name:{0}, Age:{1}, Gender:{2}, Class:{3}, Subject:{4}", name, age, isMale? "Male" : "Female", classNum, subject);
        }
    }
    #endregion
  
        #region 3
        struct Rectangle{
            public int height;
            public int width;
            public Rectangle(int height, int width){
                this.height = height;
                this.width = width;
            }
            public void PrintInfo(){
                Console.WriteLine("Rectangle length: {0}, width: {1}, area: {2}, perimeter: {3}", height, width, height * width, 2 * (height + width));
            }
        }
        #endregion
  
        #region 4
        enum Occupation{
                /// <summary>
                /// 战士
                /// </summary>
                warrior,
                /// <summary>
                /// 法师
                /// </summary>
                mage,
                /// <summary>
                /// 猎人
                /// </summary>
                hunter,

            }
        struct Player{
            public string playerName;
            public Occupation playerOccupation;

            public Player(string playerName, Occupation playerOccupation){
                this.playerName = playerName;
                this.playerOccupation = playerOccupation;
            }
            public void PrintAtkInfo(){
                string occupation = "";
                string skill = "";
                switch(playerOccupation){
                    case Occupation.warrior: 
                        occupation = "战士";
                        skill = "冲锋";
                        break;
                    case Occupation.mage:
                        occupation = "法师";
                        skill = "奥术攻击";
                        break;
                    case Occupation.hunter:
                        occupation = "猎人";
                        skill = "假死";
                        break;

                }
                Console.WriteLine("{0}{1}释放了{2}", occupation, playerName,skill);

                }
            }
  
        #endregion
  
        #region 5
        struct Monster{
            public string name;
            public int attack;
            public Monster(string name, int attack){
                this.name = name;
                this.attack = attack;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
        }
        #endregion

        #region 7
        struct OutMan{
            public string name;
            public int attack;
            public int hp;
            public int defence;
            public OutMan(string name, int attack, int hp, int defence){
                this.name = name;
                this.attack = attack;
                this.hp = hp;
                this.defence = defence;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
            public void Attack(ref Boss boss) {
                if (boss.attack > defence) {
                    boss.hp -= (attack - boss.defence);
                    Console.WriteLine("{0}攻击了{1}, 造成{2}点伤害, {3}剩余{4}点血量", name, boss.name, attack - boss.defence, boss.name, boss.hp);
                }
                else {
                    Console.WriteLine("{0}闪避了{1}的攻击", name, boss.name);
                }
            }

        }   
        struct Boss{
            public string name;
            public int attack;
            public int hp;
            public int defence;
            public Boss(string name, int attack, int hp, int defence){
                this.name = name;
                this.attack = attack;
                this.hp = hp;
                this.defence = defence;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
            public void Attack(ref OutMan outman) {
                if (outman.attack > defence) {
                    outman.hp -= (attack - outman.defence);
                    Console.WriteLine("{0}攻击了{1}, 造成{2}点伤害, {3}剩余{4}点血量", name, outman.name, attack - outman.defence, outman.name, outman.hp);
                }
                else {
                    Console.WriteLine("{0}闪避了{1}的攻击", name, outman.name);
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {   //1
            Student s1 = new Student("John", 18, true, 101, "Math");
            s1.PrintInfo();
  
            //2
            // private只能在类内部访问
            // public可以在类外部访问
  
            //3
            Rectangle r1 = new Rectangle(5, 10);
            r1.PrintInfo();

            //4
            Player p1 = new Player("唐老师", Occupation.hunter);
            p1.PrintAtkInfo();

            //6
            Monster[] monstersName = new Monster[10];
            Random r = new Random();
            for(int i = 0; i < 10; i++){
                //用结构体构造函数初始化每个怪物的名字:
                // monstersName[i].name 、 monstersName[i].attack
                monstersName[i] = new Monster("怪物" + i, r.Next(100));
                monstersName[i].PrintInfo();
            }

            //7
            OutMan outMan = new OutMan("路飞", 50, 100, 55);
            Boss boss = new Boss("索隆", 60, 200, 30);
            while(outMan.hp > 0 && boss.hp > 0){
                outMan.Attack(ref boss);
                boss.Attack(ref outMan);
            }

        }
    }
}
```

## 排序

### 冒泡排序

```csharp
//冒泡排序
static int[] BubbleSort(int[] arr){
    // 数组几个数就需要进行n轮冒泡
    for(int n=0;n<arr.Length;n++){
        //每轮冒泡
        // 数组长度减去第n轮，因为每轮冒泡都会将最大的数冒泡到最后面，所以不需要再比较后面的数
        for(int i=0;i<arr.Length-1 - n;i++){
            if(arr[i]>arr[i+1]){
                arr[i] = arr[i] + arr[i+1];
                arr[i+1] = arr[i] - arr[i+1];
                arr[i] = arr[i] - arr[i+1];
            }
        }
    }
    return arr;
}

int[] arr = { 3, 5, 8, 6, 2, 7, 1, 4};
BubbleSort(arr);
Console.WriteLine(string.Join(",", arr));
```

```csharp
//优化后的冒泡排序
static int[] BubbleSort2(int[] arr){
    // 数组几个数就需要进行n轮冒泡
    for(int n=0;n<arr.Length;n++){
        //每轮冒泡开始前，标志位isSwap置为false
        bool isSwap = false;
        //每轮冒泡
        // 数组长度减去第n轮，因为每轮冒泡都会将最大的数冒泡到最后面，所以不需要再比较后面的数
        for(int i=0;i<arr.Length-1 - n;i++){
            if(arr[i]>arr[i+1]){
                int tmp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = tmp;
                //每次交换后，isSwap置为true
                isSwap = true;
            }
        }
        //如果本轮没有发生交换，说明已经排序好了，即刻退出循环
        if(!isSwap)break;
    }
    return arr;
}

int[] arr2 = { 3, 5, 8, 6, 2, 7, 1, 4};
BubbleSort2(arr2);
Console.WriteLine(string.Join(",", arr2));
```

> 习题

![1745464509049](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220257418-85652841.png)

```csharp
#region 1
static void BubbleSortUp(int[] arr){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            //大于后面的就换位置，也就是大的放后面
            if(arr[i] > arr[i+1]){
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
                isSwap = true;
            }
        }
        if(!isSwap) break;  
    }
}
static void BubbleSortDown(int[] arr){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            //小于后面的就换位置，也就是小的放后面
            if(arr[i] < arr[i+1]){
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
                isSwap = true;
            }
        }
        if(!isSwap) break;  
    }
}
int[] arr1 = new int[20];
Random r1 = new Random();
for(int i = 0; i < arr1.Length; i++){
    arr1[i] = r1.Next(0, 101);
}
Console.WriteLine("Before Sort:"+string.Join(",", arr1));
BubbleSortUp(arr1);
Console.WriteLine("After Sort Up:"+string.Join(",", arr1));
BubbleSortDown(arr1);
Console.WriteLine("After Sort Down:"+string.Join(",", arr1));
#endregion

```

```csharp
#region 2
static void BubbleSort_UpOrDown(int[] arr,bool isUp){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            if(isUp){
                //大于后面的就换位置，也就是大的放后面
                if(arr[i] > arr[i+1]){
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSwap = true;
                }
            }
            else{
                //小于后面的就换位置，也就是小的放后面
                if(arr[i] < arr[i+1]){
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSwap = true;
                }
            } 
        }
        if(!isSwap) break; 
    }
}
int[] arr2 = new int[20];
Random r2 = new Random();
for(int i = 0; i < arr2.Length; i++){
    arr2[i] = r2.Next(0, 101);
}
BubbleSort_UpOrDown(arr2,true);
Console.WriteLine("After Sort Up:"+string.Join(",", arr2));
BubbleSort_UpOrDown(arr2,false);
Console.WriteLine("After Sort Down:"+string.Join(",", arr2));
#endregion

```

### 选择排序

**步骤：**

1. 新建中间商
2. 每轮依次比较，更新中间商
3. 找出极值
4. 中间商与目标位置互换位置
5. n轮比较

详细步骤：

1. 新建一个中间商，索引为0
2. 中间商与数组的值比较，从索引0开始向后依次比较，每次比较后更新中间商的索引为较大值(或较小值)的索引，找到极值(MAX/min)，把极值与目标位置(arr.Length-n-1)互换位置(如果是升序排列，就把MAX放在末尾)
3. 这样比较n轮，每轮比较完重置中间商的索引为0，再继续比较，后续每轮的比较只需i从1遍历到数组长度-n即可(第0个不需要和自己比较，末尾的已经排序完不需要再比较)

![1745500710062](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220258062-1300809708.png)

![1745500666622](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220258757-1288957926.png)

![1745500698048](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220259316-419419841.png)

```csharp
// 选择排序
//升序, 中间商:maxIndex,目标位置:arr[arr.Length - 1 - n]
static void SelectionSort(int[] arr){
    //n轮
    for(int n = 0; n < arr.Length - 1; n++){
        int maxIndex = 0;
        //用中间商找出每轮的最优元素maxIndex
        //只需要从1到arr.Length - n - 1遍历
        // 不需要和第0个比较(因为中间商就是索引0)，不需要和末尾的元素比较,因为arr[arr.Length - 1 - n]后面的元素在前面n轮已经排好序了
        for(int i = 1; i < arr.Length - n; i++){
            //更新中间商的索引为较大值的索引
            if(arr[i] > arr[maxIndex]){
                maxIndex = i;
            }
        }
        //交换极值和目标位置(末尾)的元素
        //交换条件：中间商不是目标位置
        if(maxIndex!= arr.Length - 1 - n){
            int tmp = arr[arr.Length - 1 - n];
            arr[arr.Length - 1 - n] = arr[maxIndex];
            arr[maxIndex] = tmp;
        }   
    }
}

int[] arr = {5, 3, 8, 6, 2, 7, 1, 4};
SelectionSort(arr);
Console.WriteLine(string.Join(" ", arr));
```

> 习题

![1745502684516](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250424220259953-1483306130.png)

```csharp
static void SelectionSort(int[] arr,bool isUp){
    for(int n = 0; n < arr.Length - 1; n++){
        int bestIndex = 0;
        for(int i = 1; i < arr.Length - n; i++){
            if(isUp){
                if(arr[i] > arr[bestIndex]){
                    bestIndex = i;
                }
            }else{
                if(arr[i] < arr[bestIndex]){
                    bestIndex = i;
                }
            }
        }
        if(bestIndex!=arr.Length-n-1){
            int temp = arr[arr.Length-n-1];
            arr[arr.Length-n-1] = arr[bestIndex];
            arr[bestIndex] = temp;
        }
    }
}

int[] arr = new int[20];
Random r = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 101);
}
Console.WriteLine("Before Sort:"+string.Join(",",arr));
SelectionSort(arr,true);
Console.WriteLine("After Sort Up:"+string.Join(",",arr));
SelectionSort(arr,false);
Console.WriteLine("After Sort Down:"+string.Join(",",arr));


```

# C#核心篇

> Github仓库：[https://github.com/EanoJiang/CSharp_core](https://github.com/EanoJiang/CSharp_core)

![1748613324370](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215808701-272444150.png)

![1748613299870](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215809525-1146266723.png)

## 面向对象的概念

封装(类)、继承，多态

## 类

### 类的基本概念

1. 具有相同特征、相同行为、一类事物的抽象
2. 类是对象的模板，可以通过类创建出对象
3. 关键词class

#### 类的申明

申明在nameplace语句块中——也就是要写在class Program 的外面，如果在类(class)里面申明类，那就是内部类

#### 语法

```csharp
namespace 面向对象;

    #region 类申明语法
    // 命名：帕斯卡命名法
    // 同一个语句块中的不同类不能重名
    //访问修饰符 class 类名{
    //     //特征——成员变量
    //     //行为——成员方法(函数)
    //     //保护特征——成员属性

    //     //构造函数、析构函数
    //     //索引器
    //     //运算符重载
    //     //静态成员
    // }
    #endregion

class Program
{

    static void Main(string[] args)
    {

    }
}

```

#### 使用

```csharp
namespace 面向对象;

class Person{
}
class Machine{
}
class Program
{
    static void Main(string[] args)
    {
        #region 实例化对象示例(类创建对象)
        //类对象都是引用类型的
        //语法: 类名 对象名 = new 类名();
        //在栈上开辟了一个空间存放地址，但是不开辟 堆内存空间，也就是null
        Person p;
        Person p1 = null;
        //分配堆内存空间
        //创建的每个对象只是模板都是同一个类，但是里面的信息都是不同的————类似造人
        Person p2 = new Person();
        Person p3 = new Person();
        #endregion
    }
}
```

> 习题

![1745540568134](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230158521-449838655.png)

```csharp
namespace 类和对象习题;

class Person{
}
class Animal{
}
class Machine{
}
class Plant{
}
class Astro{
}
class Program
{   
    static void Main(string[] args)
    {
        // 1
        Machine robot = new Machine();
        Machine machine = new Machine();
        Person people = new Person();
        Animal cat = new Animal();
        Person aunt = new Person();
        Person uncle_Wang = new Person();
        Machine car = new Machine();
        Machine plane = new Machine();
        Plant sunflower = new Plant();
        Plant chrysanthemum = new Plant();
        Astro sun = new Astro();
        Astro star = new Astro();
        Plant lotus = new Plant();
    }
}
```

```
A指向一个地址指向一块堆内存
B指向一个地址，地址拷贝自A的地址，所以也指向A的堆内存
B = null ：把B的地址与堆内存之间的指向关系断开
所以，A的堆内存没变
```

```
A和B没关系
```

### 成员变量——类的特征

1. 申明在类语句块中
2. 用来描述对象的特征
3. 任意变量类型
4. 数量不限
5. 赋不赋值都行

```csharp
namespace 成员变量;

//性别枚举
enum E_SexType{
    Male,
    Female,
}
//位置结构体
struct Position{
}
//宠物类
class Pet{
}
class Person{
    //特征——成员变量
    public string name = "Eano";//可以初始化也可以不初始化
    public int age;
    public E_SexType sex;
    public Position position;

    //可以申明任意类的对象，包括自身类
    // (这点和结构体就不同，结构体如果申明自身结构体的变量就会无限循环导致报错
    // 而在类里申明自身类的对象则没有问题，因为类是引用类型，只是声明一个对该对象的引用，也就是开辟了一个地址空间
    // 不能实例化自身类的对象，因为这样的话在后面创建对象的时候就会陷入无限循环)
    public Person girlfriend;  //不能实例化自身类的对象,初始化为null是可以的
    public Person[] friends;
    public Pet pet; //可以实例化其他类的对象
}
class Program
{
    static void Main(string[] args)
    {
        //创建对象
        Person p = new Person();
        #region 成员变量的使用与初始值
        //值类型的默认值 都是0
        //  相应的bool——false  , char——'' ,string——""
        //引用类型的默认值 都是null
        //调用defalut()方法可以查看默认值
        Console.WriteLine(default(int));
        Console.WriteLine(default(bool));
        Console.WriteLine(default(char));
        //如果不申明，那么这个成员变量就是默认值
        Console.WriteLine(p.age);
        p.age = 25;
        Console.WriteLine(p.age);
        #endregion
    }
}
```

总结：

1. 访问修饰符——3P
2. 在类里面申明自身类的对象的时候，不能实例化
3. defalut()方法得到数据类型的默认值

> 习题

![1745544012622](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230159397-6004606.png)

```csharp
3P:
private
public
protected
```

```csharp
namespace 成员变量习题;

class Student{
    public string name;
    public int age;
    public string num;
    public Student deskmate;
}

class Classroom{
    public string major;
    public int capacity;
    public Student[] students;
    public Classroom(int capacity)
    {
        this.capacity = capacity;
        students = new Student[capacity];
    }
}

class Program
{
    static void Main(string[] args)
    {
        //3
        Student s1 = new Student();
        Student s2 = new Student();
        //4
        Classroom c1 = new Classroom(5);
    }
}
```

```csharp
p.age = 10
```

```csharp
p2.age 是引用类型，拷贝的时候拷贝的是p.age的地址，改变p2.age的值，p.age也会改变
p.age = 20
```

```csharp
age是值类型，只是拷贝了s.age的值，不指向同一地址，所以s.age不变
s.age = 10
```

```csharp
s.deskmate.age = 20
```

### 成员方法——类的行为

不要加static关键字

```csharp
namespace 成员方法;

class Person{
    //成员方法
    public void Speak(string message){
        Console.WriteLine("{0}说{1}",name,message);
    }
    public bool IsAdult(){
        return age>=18;
    }
    public void AddFriend(Person p){
        if(friends==null) friends = new Person[]{p};
        else{
            Person[] temp = new Person[friends.Length+1];
            for(int i=0;i<friends.Length;i++){
                temp[i] = friends[i];
            }
            friends = temp;
            friends[friends.Length-1] = p;
        }
    }
    //成员变量
    public Person[] friends;
    public string name;
    public int age;
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Speak("Hello");
        p.name = "Tom";
        p.age = 20;
        Console.WriteLine(p.IsAdult());
        Person p2 = new Person(){name="Jerry",age=25};
        p.AddFriend(p2);
        Console.WriteLine(string.Join(",",p.friends.Select(f=>f.name)));
    }
}
```

> 习题

![1745715723169](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230200035-889430089.png)

```csharp
namespace 成员方法习题;

class Student{
    public void Speak(string message){
        Console.WriteLine("{0} says: {1}",name,message);
    }
    public void Eat(Food food){
        Console.WriteLine("{0} is eating {1},calories: {2}",name,food.name,food.calories);
    }
    public string name;
}

class Food{
    public string name;
    public int calories;
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(){name="Alice"};
        Food apple = new Food(){name="apple",calories=50};
        student.Eat(apple);
    }
}
```

### 构造、析构函数、垃圾回收机制

#### 构造函数——初始化时调用

1. 在类里面用于调用时快速初始化的函数
2. 没有构造函数的时候默认存在一个无参构造函数
   也就是 `Person p = new Person();`

##### 写法：

和结构体一样，构造函数名要和类名相同

```csharp
namespace 构造_析构函数;

class Person{
    public string name;
    public int age;
    //构造函数
    //类中允许申明无参构造函数，结构体则不允许
    public Person(){
        name = "eano";  
        age = 18;  
    }
    //构造函数可以被重载
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //现在有了3种申明并初始化对象的方式
        Person p = new Person();
        Console.WriteLine("Name: " + p.name);

        Person p2 = new Person("eano", 18);
        Console.WriteLine("Name: " + p2.name);

        Person p3 = new Person(){name = "eano", age = 18};
        Console.WriteLine("Name: " + p3.name);
    }
}
```

注意：

1. 有参构造函数 会顶掉 默认的无参构造函数。
2. 想要保留无参构造函数，需要重载出来
3. this用来区分类内成员变量和外部传入参数

##### 构造函数的特殊写法

`:this(可选参数)`复用代码

先进入无参构造函数

作用：复用先进入的构造函数代码

```csharp
    class Person{
        public string name;
        public int age;
        //构造函数
        //类中允许申明无参构造函数，结构体则不允许
        public Person(){
            name = "eano";  
            age = 18;  
        }
        // //构造函数可以被重载
        // public Person(string name, int age){
        //     this.name = name;
        //     this.age = age;
        // }
        //构造函数的特殊写法，在构造函数后:this(可选参数)
        public Person(string name, int age) : this(){
            Console.WriteLine("先进入无参构造函数");
        }
        public Person(string name, int age) : this(name){
            Console.WriteLine("先进入string类型参数的构造函数");
        }
    }
```

:this(可选参数)可以指定先进入的构造函数

可选参数可以写死，比如

:this(int类型参数名)就是先进入参数为int类型的构造函数

:this(string类型参数名)就是先进入参数为string类型的构造函数

> 习题

![1745723937810](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230200696-1084955434.png)

```csharp
namespace 构造_析构函数习题;

class Person{
    public string name;
    public int age;
    //构造函数
    public Person(){
        name = "eano";
        age = 25;
    }
    //重载
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    //特殊的构造函数
    public Person(string name):this(){
        Console.WriteLine("有参构造函数里的name:"+name);
    }
}

class Ticket{
    uint distance;
    float price;
    //构造函数
    public Ticket(uint distance){
        this.distance = distance;
        //price是通过GetPrice()方法计算出来的
        price = GetPrice();
    }
    //成员方法
    public float GetPrice(){
        if(distance > 300){
            return distance * 0.8f;
        }
        else if(distance > 200){
            return distance * 0.9f;
        }
        else if(distance > 100){
            return distance * 0.95f;
        }
        else{
            return distance * 1.0f;
        }
    }
    public void PrintPrice(){
        Console.WriteLine("距离{0}的票价为：{1}",distance,GetPrice());
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1
        //先进入无参构造函数，再进入有参构造函数
        Person p1 = new Person("John");
        Console.WriteLine(p1.name+" "+p1.age);
        //3
        Ticket t1 = new Ticket(250);
        t1.PrintPrice();
    }
}

```

#### 析构函数——释放时调用

当引用类型的堆内存真正被回收时，调用析构函数

C++需要手动管理内存，所以才需要在析构函数中做内存回收处理

C#有自带的自动垃圾回收机制，所以不太需要析构函数，除非想在某个对象被垃圾回收时做一些特殊处理

**要写在类里面**

```csharp
~类名(){

}
```

#### 垃圾回收机制GC

原理：遍历堆(Heap)上动态分配的所有对象，通过识别是否被引用来确定哪些对象是垃圾，然后回收释放

垃圾回收的算法：

1. 引用计数
2. 标记清除
3. 标记整理
4. 复制集合

堆(Heap)内存由GC垃圾回收，引用类型

栈(Stack)内存由系统自动管理，值类型在栈中分配内存，有自己的申明周期，自动分配和释放

C#中内存回收机制的原理：

> 分代算法
>
> 0代内存		1代内存		2代内存

新分配的对象都被配置在0代内存中，(0代内存满时)触发垃圾回收

在一次内存回收过程开始时，垃圾回收器会认为堆中全是垃圾，进行以下两步：

1. 标记对象：从根（静态字段、方法参数）开始检查引用对象，标记后为可达对象，被标记的为不可达对象——不可达对象就是垃圾
2. 搬迁对象压缩堆：（挂起执行托管代码线程）释放未标记的对象，搬迁可达对象到一代内存中，修改可达对象的引用地址为连续的地址

![1745723658051](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230201461-166929389.png)

大对象：

大对象是第二代内存，目的是减少性能损耗以提高性能

不会对大对象进行搬迁压缩，85000字节(83kb)以上的对象是大对象

> 这个机制有点像三级缓存
>
> 速度：0 > 1 > 2
>
> 容量：0 < 1 < 2

##### 手动进行GC

`GC.Collect()`

一般在Loading过场动画的时候调用

### 小节

```csharp
class 类名{
//特征——成员变量
//行为——成员的方法
//初始化时调用——构造函数
//释放时调用——析构函数
}
```

### 成员属性——保护成员变量

1. 通过在get和set里面写逻辑，来保护成员变量
2. 解决3p的局限性
3. 用来让成员变量在外部：只能获取不能修改  /  只能修改不能获取

#### 语法:

```csharp
    //访问修饰符 属性类型 属性名{
    //    get{}
    //    set{}
    //}
```

#### 使用：

```csharp
namespace 成员属性;

    //访问修饰符 属性类型 属性名{
    //    get{}
    //    set{}
    //}
    class Person{
        private string name;
        private int age;
        private int money;
        private bool sex;

        //成员属性
        public string Name{
            get{
                //返回之前可以写逻辑规则
                return name;
            }
            set{
                //设置之前可以写逻辑规则
                //value用来接收外部传入的值
                name = value;
            }
        }
        public int Money{
            get{
                //加密处理
                return money - 5;
            }
            set{
                //逻辑处理
                if(value < 0){
                    value = 0;
                    Console.WriteLine("金额不能为负数");
                }
                //加密处理
                //这一部分涉及到加密算法，这里省略
                money = value + 5;
            }
        }
    }

class Program
{

    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "eano";//调用的是set语句块
        Console.WriteLine(p.Name);//调用的是get语句块
        p.Money = -999;
        Console.WriteLine(p.Money);

        p.Money = 1000;
        Console.WriteLine(p.Money);
  
    }
}

```

#### get和set前可以加访问修饰符

```csharp
        #region get和set前可以加访问修饰符
        //1. 默认不加，会使用成员属性的访问修饰符(这里就是public)
        //2. 加的修饰符要低于成员属性的访问修饰符，否则会报错
        //3. 不能让get和set的访问权限都低于成员属性的权限
        public int Age{
            private get{
                return age;
            }
            set{
                age = value;
            }
        }
        #endregion
```

#### get和set可以只有一个

```csharp
        #region get和set可以只有一个
        //一般只会出现 只有get的情况，只能获取值，不能修改值————只读属性
        //只有一个的时候，不要加修饰符
        public bool Sex{
            get{
                return sex;
            }
        }
        #endregion

```

#### 自动属性

```csharp
        #region 自动属性
        //作用：外部只读不写的特性
        //使用场景：一个特征是只希望外部只读不可写，也不加别的特殊处理
        public float Height { get; private set; }
        //只可以在类内部set
        #endregion
```

> 习题

![1745798639830](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230202170-1462821562.png)

```csharp
namespace 成员属性习题;

class Student{
    private string name;
    private string sex;
    private int age;
    private int csGrade;
    private int unityGrade;
    public string Name{get; private set;}
    public string Sex{
        get{
            return sex;
        }
        private set{
            if(value != "男" && value != "女") sex = "unknown";
            else sex = value;
        }
    }
    public int Age{
        get{
            return age;
        } 
        private set{
            if(value < 0) age = 0;
            else if(value > 150) age = 150;
            else age = value;
        }
    }
    public int CsGrade{get; private set;} 
    public int UnityGrade{
        get{
            return unityGrade;
        } 
        private set{
            if(value < 0) unityGrade = 0;
            else if(value > 120) unityGrade = 120;
            else unityGrade = value;
        }
    }
  
    public Student(string name, string sex, int age, int csGrade, int unityGrade){
        Name = name;
        Sex = sex;
        Age = age;
        CsGrade = csGrade;
        UnityGrade = unityGrade;
    }
    public void Saymyself(){
        Console.WriteLine("My name is {0}, I am {1} years old, a {2}.", Name, Age, Sex);
    }
    public void SayGrade(){
        int sum = CsGrade + UnityGrade;
        float average = (float)sum / 2;
        Console.WriteLine("My sum grade is {0}, my average grade is {1}.", sum, average);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Tom", "男", 18, 90, 80);
        student1.Saymyself();
        student1.SayGrade();
        Student student2 = new Student("Jerry", "女", 160, 100, 90);
        student2.Saymyself();
        student2.SayGrade();  
    }
}
```

### 索引器——像数组一样访问元素

让对象可以像数组一样通过索引访问元素

注意：结构体中也支持索引器

#### 语法

```csharp
    class Person{
        private string name;
        private int age;
        private Person[] friends;

        #region 索引器语法
        //访问修饰符 返回值 this[数据类型 参数名1，数据类型 参数名2，...]{ 
        //   和属性的写法相同：
        //   get{
        //   }
        //   set{
        //   }
        // }
        public Person this[int index]{
            get{
                return friends[index];
            }
            set{
                friends[index] = value;
            }
        }

        #endregion

    }

```

#### 用法

```csharp
namespace 索引器;

class Person{
    private string name;
    private int age;
    private Person[] friends;
    private int[,] array;
    public string Name{get;private set;}
    public int Age{get;private set;}
    public Person[] Friends{get;private set;}
    public int[,] Array{get;private set;}
    public Person(string name, int age){
        Name = name;
        Age = age;
        friends = new Person[5];
        Friends = friends;
        array = new int[3, 4];
        Array = array;
    }

    #region 索引器语法
    //访问修饰符 返回值 this[数据类型 参数名1，数据类型 参数名2，...]{ 
    //   和属性的写法相同：
    //   get{
    //   }
    //   set{
    //   }
    // }
    public Person this[int index]{
        get{
            #region 索引器里也能写逻辑
            if(friends == null || index < 0 || index >= friends.Length){
                return null;
            }
            else{
                return friends[index];
            }
            #endregion
        }
        set{
            if(friends == null){
                friends = new Person[]{value};
            }
            //如果越界，顶掉最后一个元素
            else if(index < 0 || index >= friends.Length){
                friends[friends.Length - 1] = value;
            }
            else friends[index] = value;
        }
    }
    #endregion

    #region 索引器可以重载
    //参数不同
    public int this[int row, int col]{
        get{
            return array[row, col];
        }
        set{
            array[row, col] = value;
        }
    }
    public string this[string str]{
        get{
            switch(str){
                case "name":
                    return Name;
                case "age":
                    return Age.ToString();
                default:
                    return "Invalid index";
            }
        }
    }
    #endregion
}

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person("Alice", 25);
        p1.Friends[0] = new Person("Bob", 20);
        p1[1] = new Person("Charlie", 22);
        Console.WriteLine(p1[0].Name);
        p1[2, 3] = 10;
        Console.WriteLine(p1[2, 3]);
        Console.WriteLine("{0}的年龄是{1}, 朋友是{2}", p1["name"],p1["age"],p1[0]["name"]);
    }
}
```

> 索引器就相当于给对象加一个属性，用中括号[参数]调用这个属性的内容

> 习题

![1745803440897](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230202804-607628857.png)

```csharp
namespace 索引器习题;

class IntArray{
    public int[] arr;
    public int length;
    public IntArray(int size){
        length = 0;
        arr = new int[size];
    }
    //增
    public void Add(int index, int value){
        if(index < 0 || index > length){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            if(length < arr.Length){
                arr[length] = value;
                length++;
            }
            else{
                int[] newArr = new int[arr.Length + 1];
                for(int i=0;i<arr.Length;i++){
                    newArr[i] = arr[i]; 
                }
                arr = newArr;
                //后面元素后移
                for(int i = length-1;i>=index;i--){
                    arr[i+1] = arr[i];
                }
                arr[index] = value;
                length++;
            }  
        }   
    }
    //删
    public void Remove(int index){
        if(index > length-1 || index < 0){
            Console.WriteLine("索引超出范围");
            return;
        }
        else{
            //后面元素前移
            for(int i = index;i<length-1;i++){
                arr[i] = arr[i+1];
            }
            length--;
        }
    }
    //索引器
    //查
    //改
    public int this[int index]{
        get{
            return arr[index];
        }
        set{
            arr[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        IntArray arr = new IntArray(5);
        arr.Add(0,1);
        arr.Add(1,2);
        arr.Add(2,3);
        arr.Add(3,4);
        arr.Add(4,5);
        arr.Add(5,6);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);

        arr.Remove(2);
        for(int i=0;i<arr.length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(arr.length);
        arr[0] = 10;
        Console.WriteLine(arr[0]);
    }
}
```

### 静态成员——类名.出来使用

静态关键字 static

修饰成员变量、方法、属性

静态成员可以用 `类名.静态成员名`直接调用

一般写成public公共的

#### 申明与使用

```csharp
namespace 静态成员;

class Test{
    static public float PI = 3.14f;
    public int testInt = 10;
    static public float CircleArea(float r){
        #region 静态函数不能访问非静态成员
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);
        #endregion
        return PI * r * r;
    }
    public void TestFunc(){
        Console.WriteLine("This is a test function");
        #region 非静态函数可以使用静态成员
        Console.WriteLine(PI);
        Console.WriteLine(CircleArea(5));
        #endregion
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region 静态成员的使用
        Console.WriteLine(Test.PI);
        // Console.WriteLine(Test.testInt); // 不能直接类名.调用
  
        // 非静态成员只能在实例化对象后调用
        Test t = new Test();
        Console.WriteLine(t.testInt);

        Console.WriteLine(Test.CircleArea(5));
        //Console.WriteLine(Test.TestFunc());// 不能直接类名.调用
        t.TestFunc();
        #endregion
    }
}
```

#### 为什么可以类名.静态成员名使用

程序开始运行的时候，就会给静态成员分配内存空间

静态成员与程序共生死

每个静态成员都会有一个唯一的内存空间

直到程序结束，静态成员的内存空间才会被释放

#### 作用

1. 申明唯一变量
2. 方便在其他地方获取的对象的申明
3. 申明唯一方法——相同规则的数学计算

#### 问题

长期占用内存空间，其他非静态成员gc的阈值变小，程序性能降低

#### 常态和静态变量

相同点：

1. 都可以通过类名.出来使用

不同点：

1. const修饰常量，必须初始化，不能修改
2. const要直接写在变量的前面，也就是访问修饰符的后面
3. const只能修饰变量，static还可以修饰方法、属性

> 习题

![1745823537297](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230203353-1759878110.png)

```csharp
namespace 静态成员习题;

//单例模式
class Test{
    private static Test t = new Test();
    public int testInt = 10;
    public static Test T{
        get{
            return t;
        }
    }
    private Test(){
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Test.T.testInt);
        Test.T.testInt = 20;
        // Test t1 = new Test();    //外部无法实例化
        Console.WriteLine(Test.T.testInt);
    }
}
```

### 静态类和静态构造函数

作为工具使用，就像Console类一样，直接类名.出来使用静态成员

#### 静态类

static修饰的类

1. 只能包含静态成员
2. 不能被实例化

作用：

1. 将常用的静态成员写在静态类中
2. 静态类不能被实例化，体现工具类的唯一性

#### 静态构造函数

static修饰的构造函数

1. 静态类和非静态类都可以用静态构造函数
2. 静态构造函数不能使用访问修饰符
3. 不能有参数
4. 只会调用一次

静态构造函数只会在第一次使用类的时候调用一次，与类是否是静态类无关

普通构造函数每次实例化类的对象都会调用一次

```csharp
using System.Runtime.CompilerServices;

namespace 静态类和静态构造函数;

#region 静态类
static class TestStatic{
    public static void TestFunc(){

    }
    //静态类只能包含静态成员
    // public void Say(){
    // }
    public static int TestIndex{get;set;}
}
#endregion

#region 静态构造函数
//1. 静态类中的静态构造函数
static class StaticClass{
    public static int testInt = 10;
    //静态构造函数不能加访问修饰符
    //无参
    static StaticClass(){
        Console.WriteLine("静态类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }

}
//2. 普通类中的静态构造函数
class NormalClass{
    public static int testInt = 10;
    static NormalClass(){
        Console.WriteLine("普通类中的静态构造函数执行");
        //在静态构造函数里初始化成员变量
        testInt = 20;
    }
    public NormalClass(){
        Console.WriteLine("普通类中的普通构造函数执行");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //调用两次静态成员，但只执行一次静态构造函数
        Console.WriteLine(StaticClass.testInt);
        Console.WriteLine(StaticClass.testInt);

        //普通类中的静态构造函数也只执行一次
        Console.WriteLine(NormalClass.testInt);
        Console.WriteLine(NormalClass.testInt);
        //普通类中的普通构造函数每次实例化都会执行
        NormalClass nc = new NormalClass();
        NormalClass nc2 = new NormalClass();
  
    }
}

```

> 习题

![1745938803133](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230203930-1707158414.png)

```csharp
namespace 静态类和静态构造函数习题;

static class MathCalc{
    const float pi = 3.14f;
    public static float CircleArea(float r){
        Console.WriteLine("半径为{0}的圆的面积为{1}", r, pi * r * r);
        return pi * r * r;
    }
    public static float CirclePerimeter(float r){
        Console.WriteLine("半径为{0}的圆的周长为{1}", r, 2 * pi * r);
        return 2 * pi * r;
    }
    public static float RectangleArea(float a, float b){
        Console.WriteLine("长为{0}宽为{1}的矩形的面积为{2}", a, b, a * b);
        return a * b;
        }
    public static float RectanglePerimeter(float a, float b){
        Console.WriteLine("长为{0}宽为{1}的矩形的周长为{2}", a, b, 2 * (a + b));
        return 2 * (a + b);
    }
    public static float Abs(float n){
        float n1 = (n > 0)?n:-n;
        Console.WriteLine("{0}绝对值为{1}", n, n1);
        return n1;
    }
    static MathCalc(){
        Console.WriteLine("静态构造函数执行");
    }

}

class Program
{
    static void Main(string[] args)
    {
        MathCalc.CircleArea(5);
        MathCalc.CirclePerimeter(5);
        MathCalc.RectangleArea(5, 10);
        MathCalc.RectanglePerimeter(5, 10);
        MathCalc.Abs(-5);
    }
}

```

### 拓展方法

为现有非静态变量类型 添加新方法

作用：

1. 提升程序拓展性
2. 不需要在对象中重新写方法
3. 不需要继承来添加方法
4. 为别人封装的类写额外的方法

特点：

1. 一定写在静态类中
2. 一定是一个静态函数
3. 第一个参数是拓展目标(想要拓展方法的类型)，要用this修饰

#### 语法

```csharp
访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){

}
```

```csharp
namespace 拓展方法;

    #region 语法
    //访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){
    //
    //}
    #endregion

    #region 示例
    static class Tools{
        public static void Print(this string str){
            Console.WriteLine("为string拓展方法："+str);
        }
    }

    #endregion

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        str.Print(); //调用拓展方法
    }
}

```

#### 使用

```csharp
namespace 拓展方法;

    #region 语法
    //访问修饰符 static 返回值类型 函数名(this 拓展类名 参数名，参数数据类型 参数, ...){
    //
    //}
    #endregion

    #region 示例
    static class Tools{
        public static void Print(this string str){
            Console.WriteLine("为string拓展方法："+str);
        }
        public static void PrintInfo(this string str, string str1, int num){
            Console.WriteLine("拓展方法的对象："+str);  
            Console.WriteLine("传入的参数："+str1 + " " + num);
        }
        public static void PrintInfo(this Test t){
            Console.WriteLine("为Test类拓展方法："+t.i);
        }
        //如果拓展的方法名和类里面的方法重名，优先使用类的方法
        public static void Func(this Test t){
            Console.WriteLine("为Test类拓展同名方法：");
        }
    }
    #endregion
  
    #region 为自定义的类型拓展方法
    class Test{
        public int i = 10;
        public void Func(){
            Console.WriteLine("Test类自己的Func方法");
        }
    }
    #endregion

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello World";
        str.Print(); //调用拓展方法
        str.PrintInfo("你好", 123); //调用拓展方法

        //为自定义的类型拓展方法
        Test t = new Test();
        t.PrintInfo(); //调用拓展方法
        t.Func(); //重名，优先调用类自己的方法
    }
}

```

注意：

如果拓展的方法名和类里面的方法重名，优先使用类的方法

> 习题

![1745975969697](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230204576-1609497964.png)

```csharp
namespace 拓展方法习题;

//1
//平方
static class Test{
    public static int Square(this int n){
        Console.WriteLine("Square of " + n + " is " + (n*n));
        return n*n;
    }
    public static void Suicide(this Player player){
        Console.WriteLine("Player " + player.name + " is suiciding!");
    }
}

//2
//玩家
class Player{
    public string name;
    public int hp;
    public int atk;
    public int def;
    public Player(string name, int hp, int atk, int def){
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
    }
    public void Attack(Player target){
        Console.WriteLine(this.name + " attacks " + target.name + "!");
        target.hp -= this.atk - target.def;
        Console.WriteLine(target.name + " now has " + target.hp + " HP.");
        if(this.atk - target.def > 0){
            Hurted(target);
        }
    }
    public void Move(int x, int y){
        Console.WriteLine(this.name + " moves to (" + x + ", " + y + ").");
    }
    public void Hurted(Player target){
        Console.WriteLine(target.name + " is hurt!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //1
        int num = 3;
        num.Square();
        //2
        Player player1 = new Player("player1", 100, 10, 5);
        Player player2 = new Player("player2", 100, 13, 2);
        player1.Attack(player2);
        player1.Move(1, 2);
        player1.Suicide();
        player2.Attack(player1);
        player2.Suicide();


    }
}

```

### 运算符重载——自定义对象能够运算

让自定义的类和结构体对象 能够使用运算符

关键字： operator

特点：

1. 必须是公共的静态方法
2. 返回值写在operator前

注意：

1. 条件运算符需要成对实现
2. 一个符号可以多个重载
3. 不能使用ref和out

#### 语法

```csharp
    //语法
    //public static 类名 返回类型 operator 运算符(参数类型1 参数名1, 参数类型2 参数名2){
    //}
```

#### 用法实例

```csharp
namespace 运算符重载;

class Program
{
    //语法
    //public static 类名 返回类型 operator 运算符(参数类型1 参数名1, 参数类型2 参数名2){
    //}

    //实例
    class Point {
        public int x, y;
        public static Point operator +(Point p1, Point p2) {
            Point p = new Point();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;
        }
        //重载
        public static Point operator +(Point p1, int num) {
            Point p = new Point();
            p.x = p1.x + num;
            p.y = p1.y + num;
            return p;
        }
    }
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.x = 1;
        p1.y = 2;
        Point p2 = new Point();
        p2.x = 3;
        p2.y = 4;
        Point p3 = p1 + p2;
        Console.WriteLine("p3.x = " + p3.x);
        Point p4 = p1 + 2;
        Console.WriteLine("p4.x = " + p4.x);
        //可以连续使用
        p4 = p1 + p2 + 3;
        Console.WriteLine("p4.x = " + p4.x);
    }
}

```

#### 可重载和不可重载的运算符

```csharp
    #region 可重载的运算符
    //算数运算符：+ - * / %  ++ --
    // (自增自减的参数只有一个)

    //逻辑运算符：!
    // （ &&和||不能重载 ）

    //位运算符：~ & | ^ << >>
    // (~只有一个参数)
    // (左移右移的参数Point p,int num)

    //条件运算符：> < >= <= == !=
    //条件运算符需要成对实现
    // 也就是>和<需要成对重载，>=和<=需要成对重载，==和!=需要成对重载
  
    #endregion

    #region 不可重载的运算符
    //逻辑运算符：&& ||
    //索引符：[]
    //强转运算符：()
    //特殊运算符：点.  三目运算符的?  赋值符号=
    #endregion
```

> 习题

![1745982049807](https://img2023.cnblogs.com/blog/3614909/202504/3614909-20250430230205225-1861371618.png)

```csharp
namespace 运算符重载习题;

//1
class Position{
    public int x;
    public int y;
    public static bool operator ==(Position p1, Position p2){
        if(p1.x == p2.x && p1.y == p2.y){
            return true;
        }
        return false;
    }
    public static bool operator !=(Position p1, Position p2){
        if(p1.x!= p2.x || p1.y!= p2.y){
            return true;
        }
        return false;
    }
}

//2
class Vector3{
    public int x;
    public int y;
    public int z;
    public static Vector3 operator +(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x + v2.x;
        result.y = v1.y + v2.y;
        result.z = v1.z + v2.z;
        return result;
    }
    public static Vector3 operator -(Vector3 v1, Vector3 v2){
        Vector3 result = new Vector3();
        result.x = v1.x - v2.x;
        result.y = v1.y - v2.y;
        result.z = v1.z - v2.z;
        return result;
    }
    public static Vector3 operator *(Vector3 v1, int n){
        Vector3 result = new Vector3();
        result.x = v1.x * n;
        result.y = v1.y * n;
        result.z = v1.z * n;
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1
        Position a = new Position();
        a.x = 1;
        a.y = 2;
        Position b = new Position();
        b.x = 1;
        b.y = 2;
        Console.WriteLine(a == b); // True
        Console.WriteLine(a!= b); // False
        //2
        Vector3 v1 = new Vector3();
        v1.x = 1;
        v1.y = 2;
        v1.z = 3;
        Vector3 v2 = new Vector3();
        v2.x = 2;
        v2.y = 3;
        v2.z = 4;
        Vector3 v3 = v1 + v2;
        Console.WriteLine("(v3.x, v3.y, v3.z) = ({0}, {1}, {2})", v3.x, v3.y, v3.z);
        Vector3 v4 = v1 - v2;
        Console.WriteLine("(v4.x, v4.y, v4.z) = ({0}, {1}, {2})", v4.x, v4.y, v4.z);
        Vector3 v5 = v1 * 2;
        Console.WriteLine("(v5.x, v5.y, v5.z) = ({0}, {1}, {2})", v5.x, v5.y, v5.z);
    }
}

```

### 内部类和分部类

#### 内部类——在一个类中申明一个类

要用包裹者点出这个内部类

作用：亲密关系的体现，有点像继承

注意：访问修饰符作用很大

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

    }
}

```

#### 分部类——一个类分成几部分申明

关键字：partial

作用：分部描述一个类，增加程序的可拓展性

注意：

1. 分部类可以写在多个脚本文件中
2. 分部类的访问修饰符要一致
3. 分部类中不能有重复的成员

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

#region 分部类
partial class Student{
    public bool sex;
    public string name;
}
partial class Student{
    public int age;
    //注意不要重复成员名
    //  public string name; 
    public void SayHello(){
        Console.WriteLine("Hello,I'm {0},age is {1}",name,age);
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        //内部类
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

        //分部类
        Student student = new Student();
        student.age = 18;
        student.name = "Tom";
        student.sex = true;
        student.SayHello();
    }
}

```

#### 分部方法——将方法的申明和实现分离

注意：

1. 不能加访问修饰符，默认私有
2. 只能在分部类里申明
3. 返回值只能是void
4. 参数不能用out关键字

```csharp
namespace 内部类和分部类;

#region 内部类
class Person{
    public string name;
    public int age;
    public Body body;

    public class Body{
        Arm leftArm;
        Arm rightArm;
        class Arm{

        }
    }
}
#endregion

#region 分部类
partial class Student{
    public bool sex;
    public string name;
    public partial void SayHello();
}
partial class Student{
    public int age;
    //注意不要重复成员名
    //  public string name; 

    public partial void SayHello(){
        Console.WriteLine("I'm {0},age:{1}", name, age);
    }
}

#endregion

class Program
{
    static void Main(string[] args)
    {
        //内部类
        Person person = new Person();
        person.body = new Person.Body();
        //访问修饰符的作用，不写public，则无法访问
        //  person.body.leftArm = new Person.Body.Arm();

        //分部类
        Student student = new Student();
        student.age = 18;
        student.name = "Tom";
        student.sex = true;
        student.SayHello();
    }
}

```

## 继承

### 继承的基本概念

子类继承父类的所有成员、特征和行为

子类可以有自己的特征和行为

**单根性**：子类只能有一个父类

**传递性**：子类可以**间接继承父类的父类**

#### 语法

```csharp
namespace 继承;

#region 继承语法
class Teacher{
    public string name;
    public int number;
    public void PrintName(){
        Console.WriteLine("My name is " + name + " " + number);
    }
}
//子类
class TeachingTeacher : Teacher{
    //子类独有的属性
    public string subject;
    public void PrintSubject(){
        Console.WriteLine("My subject is " + subject);
    }
}
//子类的子类
class ChineseTeacher : TeachingTeacher{
    public void PrintChinese(){
        Console.WriteLine("xxxx");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        TeachingTeacher teacher1 = new TeachingTeacher();
        teacher1.name = "John";
        teacher1.number = 9527;
        teacher1.subject = "Math";
        teacher1.PrintName();
        teacher1.PrintSubject();
        //传递性继承
        ChineseTeacher teacher2 = new ChineseTeacher();
        teacher2.name = "Mary";
        teacher2.number = 9528;
        teacher2.subject = "Chinese";
        teacher2.PrintName();
        teacher2.PrintSubject();
        teacher2.PrintChinese();
    }
}

```

#### 访问修饰符对继承的影响

private、public、protected、internal

private：只有内部能访问，子类不能访问，但是子类里可以调用父类的公共方法来间接传入private参数(实际上还是在父类里面调用的private参数)

```csharp
class Teacher{
    public string name;
    private int number;
    public void PrintName(int number){
        this.number = number;
        Console.WriteLine("My name is " + name + " " + number);
    }
}
//子类
class TeachingTeacher : Teacher{
    public new string name;
    //子类独有的属性
    public string subject;
    public void PrintSubject(int number){
        //子类里可以调用父类的公共方法来间接传入private参数
        PrintName(number);
        Console.WriteLine("My subject is " + subject);
    }
}
```

**protected**：保护的是内部和子类

也就是希望**外部不能调用，但是其内部和子类可以调用**

```csharp
namespace 继承;

#region 继承语法
class Teacher{
    public string name;
    protected int number;
    public void PrintName(int number){
        //内部可以调用protected属性
        this.number = number;
        Console.WriteLine("My name is " + name + " " + number);
    }
}
//子类
class TeachingTeacher : Teacher{
    //子类独有的属性
    public string subject;
    public void PrintSubject(int number){
        //子类里可以调用protected属性
        this.number = number;
        Console.WriteLine("My subject is " + subject);
    }
}
//子类的子类
class ChineseTeacher : TeachingTeacher{
    public void PrintChinese(int number){
        this.number = number;
        Console.WriteLine("xxxx");
    }
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        //语法
        TeachingTeacher teacher1 = new TeachingTeacher();
        teacher1.name = "John";
        //外部无法调用protected属性number
        // teacher1.number = 9527;
        teacher1.subject = "Math";
        //只能公共方法来传参，因为内部和子类可以访问protected属性
        teacher1.PrintName(9527);
        teacher1.PrintSubject(9527);
        //传递性继承
        ChineseTeacher teacher2 = new ChineseTeacher();
        teacher2.name = "Mary";
        //外部无法调用protected属性number
        // teacher2.number = 9528;
        teacher2.subject = "Chinese";
        //只能公共方法来传参，因为内部和子类可以访问protected属性
        teacher2.PrintName(9528);
        teacher2.PrintSubject(9528);
        teacher2.PrintChinese(9528);
    }
}

```

internal：内部的，只有在同一个程序集文件中，内部类型或成员才能访问

> 在后面命名空间再讲internal

#### 子类和父类的同名成员

C#中允许出现子类和父类存在同名成员：

子类里可以命名和父类同名的成员，但是声明子类对象的时候，子类的成员会顶替父类。

最好别用这个特性

要用的时候，最好在前面加上new，用来表明这是一个新的成员，顶替父类里的同名成员。

![1746585122615](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222441758-289765390.png)

> 习题

![1746585220823](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222442832-1715955100.png)

```csharp
namespace 继承习题;

class Person{
    public string name;
    public int age;
    public void SayHello(){
        Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");
    }
}

class Warrior : Person{
    public void Atk(Person person){
        Console.WriteLine("Warrior {0} attacks {1}!", name, person.name);
    } 
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Alice";

        Warrior warrior = new Warrior();
        warrior.name = "John";
        warrior.age = 30;
        warrior.SayHello();
        warrior.Atk(person);
    }
}

```

### 继承_里氏替换原则

> **面向对象七大原则**
>
> 开闭原则：对扩展开放，对修改封闭
>
> 单一职责原则：一个类只负责一项职责
>
> 依赖倒置原则：高层模块不应该依赖低层模块，二者都应该依赖抽象
>
> 接口隔离原则：使用多个专门的接口，而不使用单一的总接口
>
> 迪米特法则：一个对象应该对其他对象有最少的了解
>
> 里氏替换原则：子类对象必须能够替换其父类对象
>
> 违反开闭原则：违反开闭原则的设计是不好的设计

#### 里氏替换原则的基本概念

任何父类出现的地方，子类都可以替代

父类容器装子类对象，因为子类对象包含了父类的所有内容

**作用**：方便进行对象储存和管理

#### 语法

```csharp
namespace 继承_里氏替换原则;

class GameObject{
  
}
class Player : GameObject{
    public void Attack(GameObject target){
        Console.WriteLine("{0}Attack{1}", this, target);
    }
}
class Monster : GameObject{

}
class Boss : GameObject{

}

class Program
{
    static void Main(string[] args)
    {
        #region 里氏替换原则语法
        //父类容器 装 子类对象
        GameObject player = new Player();
        GameObject monster = new Monster();
        GameObject boss = new Boss();

        GameObject[] objects = new GameObject[] { new Player(), new Monster(), new Boss()};
        #endregion
  
    }
}

```

这样写了之后不能子类名.调用其方法，所以有了下面的两个关键字。

#### is 和 as 关键字

is判断，as转换

 **is**：判断一个对象是否是指定类对象

返回：bool

语法很接近自然语言

```csharp
        #region is 和 as 关键字
        if(player is Player){
  
        }
        else if(player is Monster){

        }
        #endregion
```

**as**：讲一个对象转换为指定类对象

返回：指定类型对象，否则失败就返回null

```csharp
       Player p = player as Player;
       Monster m = player as Monster;
       Console.WriteLine(p);
       Console.WriteLine(m == null);//true
```

**is和as配合使用**

```csharp
       #region is和as的配合使用
       if(player is Player){

        // Player p1 = player as Player;
        // p1.Attack(monster);
  
        (player as Player).Attack(monster);

       }
       #endregion
```

```csharp
        //当不知道objects数组里的内容，需要遍历判断
        for(int i = 0; i < objects.Length; i++){
            //objects数组里的Player类型对象
            if(objects[i] is Player){
                (objects[i] as Player).Attack(monster);
            }
            else if(objects[i] is Monster){
                //objects数组里的Monster类型对象
                //...
            }
            else if(objects[i] is Boss){
                //objects数组里的Boss类型对象
                //...
            }
        }
```

#### **不能用子类容器装父类对象**

因为父类对象的方法比子类少

```csharp
// Player p2 = new GameObjects();	//错误
```

> 习题

![1746670802429](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222443596-639089371.png)

```csharp
namespace 继承_里氏替换原则习题;

class Monster{
  
}
class Boss : Monster{
    public void Skill(){
        Console.WriteLine("Boss Skill");
    }
}
class Goblin : Monster{
    public void Atk(){
        Console.WriteLine("Goblin Atk");
    }
}

class Player{
    public Weapon nowWeapon;
    public Player(){
        //默认武器：匕首
        nowWeapon = new Dagger();
    }
    //切换武器
    public void Converse(Weapon weapon){
        nowWeapon = weapon;
    }
    public void PrintWeapon(){
        Console.WriteLine("now I have a {0}", nowWeapon.name);
    }

}
class Weapon{
    public string name;

}
class MP9 : Weapon{
    public MP9(){
        name = "MP9";
    }
}
class ShotGun : Weapon{
    public ShotGun(){
        name = "ShotGun";
    }
}
class Pistol : Weapon{
    public Pistol(){
        name = "Pistol";
    }
}
class Dagger : Weapon{
    public Dagger(){
        name = "Dagger";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //习题1
        Random r = new Random();
        int randomNum;
        Monster[] monsters = new Monster[10];
        //随机生成10个怪物，二者生成概率都是50%
        for(int i = 0; i < monsters.Length; i++){
            randomNum = r.Next(0,2);
            if(randomNum == 1){
                monsters[i] = new Boss();
            }
            else{
                monsters[i] = new Goblin();
            }
        }
        for(int i = 0; i < monsters.Length; i++){
            if(monsters[i] is Boss){
                (monsters[i] as Boss).Skill();
            }
            else if(monsters[i] is Goblin){
                (monsters[i] as Goblin).Atk();
            }
        }

        //习题2
        Player player = new Player();
        player.PrintWeapon();
        Console.WriteLine("下面开始捡东西");
        Weapon[] weapons = new Weapon[4]{new MP9(), new ShotGun(), new Pistol(), new Dagger()};
        for(int i = 0; i < weapons.Length; i++){
            player.Converse(weapons[i]);
            player.PrintWeapon();
        }

    }
}

```

### 继承中的构造函数

当申明一个子类对象的时候，先执行父类的构造函数，再执行子类的构造函数

注意：

1. 父类的无参构造

子类默认调用的是父类的无参构造函数

```csharp
#region 父类无参构造函数的重要性
class Parent{
    //有参构造函数会顶掉无参构造函数
    public Parent(int i){
        Console.WriteLine("Parent 构造函数");
    }
}
class Child: Parent{
    //子类默认调用的是父类的无参构造函数
    //找不到父类无参构造函数，会报错
    public Child(){
        Console.WriteLine("Child 构造函数");
    }
}
#endregion
```

2. 子类可以通过base关键字，调用父类的指定构造函数
   (先调用父类，再调用子类另外写的)

```csharp
#region 通过base关键字,调用父类的指定构造函数
class Parent{
    //有参构造函数会顶掉无参构造函数
    public Parent(int i){
        Console.WriteLine("Parent 有参int构造函数");
    }
    public Parent(string str){
        Console.WriteLine("Parent 有参string构造函数");
    }
}
class Child: Parent{
    //base(传入父类构造函数的参数)
    public Child(int i) : base(i){
        Console.WriteLine("Child int参数构造函数");
    }
    public Child(string str) : base(str){
        Console.WriteLine("Child str参数构造函数");
    }
    //调用父类的有参int构造函数
    public Child(int i, string str) : base(i){
        Console.WriteLine("Child 两个参数构造函数");
    }
    //通过调用该子类的第一个构造函数(int i)，
    // 间接调用父类的有参int构造函数
    // public Child(int i, string str):this(i){
    // }
    //  和上面是等价的
}
#endregion
```

> 习题

![1746775248315](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222444353-1212244995.png)

```csharp
namespace 继承_构造函数习题;

class Worker{
    public string jobType;
    public string jobContent;
    public Worker(){
    }
    public Worker(string jobType, string jobContent){
        this.jobType = jobType;
        this.jobContent = jobContent;
    }
    public void Work(){
        Console.WriteLine("I am a worker, my job is {0} and my job content is {1}", jobType, jobContent);
    }
}
class Programmer : Worker{
    public Programmer():base("Programmer", "Coding"){

    }
}
class Strategist : Worker{
    public Strategist():base("Strategist", "Planning"){

    }
}
class Artist : Worker{
    public Artist():base("Artist", "Drawing"){
    }
}


class Program
{
    static void Main(string[] args)
    {
        Programmer p = new Programmer();
        p.Work();
        Strategist s = new Strategist();
        s.Work();
        Artist a = new Artist();
        a.Work();
    }
}

```

### 万物之父和装箱拆箱

#### 万物之父

**关键字**：object

object是所有类型的基类

**作用**：

1. 利用里氏替换原则，用object作为父类容器装所有对象
2. 用来表示不确定类型，作为函数的参数类型

```csharp
namespace 继承_万物之父与装箱拆箱;

class Father{
    public void Speak(){
        Console.WriteLine("I am Father.");
    }
}
class Son : Father{

}

class Program
{
    static void Main(string[] args)
    {
        //用object容器装任意对象
        object o = new Son();
        Son s = new Son();
        o = s;
        Father f = new Father();
        o = f;
        //用is和as来调用容器里的对象的成员
        if(o is Father)(o as Father).Speak();

        #region object对象的类型转换

        //值类型 —— 强转
        //用object容器装任意值类型
        object o2 = 1f;
        //要当成数字用的话，需要强转
        int f1 = (int)o2;

        //引用类型 —— as转换
        //string类型
        object o3 = "111";
        string s1 = (string)o3;
        s1 = o3 as string;
        s1 = o3.ToString();
        //数组类型
        object o4 = new int[3];
        int[] arr = o4 as int[];
        arr = (int[])o4;

        #endregion

    }
}

```

#### 装箱拆箱

装箱：用object存值类型——引用类型存值类型，栈内存会迁移到堆内存

拆箱：把object转为值类型——值类型从引用类型取出，堆内存迁移到栈内存

优点：方便在不确定类型时对参数进行存储和传递

缺点：存在内存迁移，增加性能消耗

```csharp
        #region 装箱拆箱
        object o5 = 3;
        int i1 = (int)o5;

        Func(1,2,3.1f,"dsadsajda",new Son());
        //传任意类型参
        void Func(params object[] arr){

        }
        void Func1(object o){

        }

        #endregion
```

### 密封类

关键字**sealed修饰的类**

让类无法再被继承

类似**结扎**

```csharp
class Father{

}
//表示这就是最后一个子类，不能再往下继承了
//类似结扎
sealed class Son : Father{

}
```

**作用：**

在面向对象程序设计中，密封类就是不允许某个最底层子类再被继承

可以保证程序的规范性和安全性

### 继承部分综合习题

![1746780536078](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250519222445009-624308117.png)

```csharp
namespace 继承_综合习题;

class Car{
    public int speed;
    public int maxSpeed;
    //当前的人数
    public int num;
    public Person[] persons;
    public Car(int speed, int maxSpeed, int maxNum){
        this.speed = speed;
        this.maxSpeed = maxSpeed;
        this.num = 0;
        persons = new Person[maxNum];
    }
    public void AddPerson(Person person){
        if(num >= persons.Length){
            Console.WriteLine("车子已满");
            return;
        }
        persons[num] = person;
        num++;
    }
    public void RemovePerson(Person delPerson){
        if(delPerson is Driver){
            Console.WriteLine("驾驶员不能下车");
            return;
        }
        //只有乘客下车
        else{
            for(int i = 0; i < persons.Length; i++){
                //结束循环的条件是找到空位
                if(persons[i] == null){
                    break;
                }
                // 找到要删除的对象
                else if(persons[i] == delPerson){
                    // 找到了要删除的对象，将其后面的元素前移一位
                    for(int j = 0; j < num - 1; j++){
                        persons[j] = persons[j+1];
                    }
                    //最后一个位置清空
                    persons[num-1] = null;
                    num--;
                    break;
                }
            }
        }
    }

    public void Move(){
    }
    public void Accident(){
        if(speed > maxSpeed)
            Console.WriteLine("发生事故");
        else
            Console.WriteLine("正常");
    }
    public void PrintNum(){
        Console.WriteLine("当前车子乘客数量：" + num);
    }
}
class Person{

}
class Driver:Person{

}
class Passenger:Person{

}

class Program
{
    static void Main(string[] args)
    {
        Person d1 = new Driver();
        Person p1 = new Passenger();
        Person p2 = new Passenger();
        Car car = new Car(60, 80, 5);
        car.AddPerson(d1);
        car.AddPerson(p1);
        car.AddPerson(p2);
        car.PrintNum();
        car.RemovePerson(d1);
        car.PrintNum();
        car.RemovePerson(p1);
        car.PrintNum();
        car.Accident();
        car.speed = 100;
        car.Accident();
   
    }
}

```

## 多态

### 多态的基本概念

让继承同一父类的子类们，在执行相同方法的时候有不同的表现

解决问题：**让同一个对象有唯一行为的特征**

```csharp
class Father
{
    public void SpeakName()
    {
        Console.WriteLine("Father类");
    }
}
class Son : Father
{
    public new void SpeakName()
    {
        Console.WriteLine("Son类");
    }
}

class Program
{
    static void Main(string[] args)
    {
        //如果用里氏替换原则
        Father s = new Son();
        s.SpeakName();  //这里会打印父类的方法
        //只有用as转换成子类对象才会调用子类的方法
        (s as Son).SpeakName();
    }
}
```

这样写很容易造成混乱，于是就有了多态

### 多态的实现

前面学过函数重载，这是编译时候的多态，也叫做静态的多态，意思是在程序编译阶段，编译器根据**参数的类型和数量**来决定调用哪个具体的重载函数版本。

下面介绍的是运行时的多态(vob、抽象函数、接口)

### vob

v：virtual（虚函数）

o：override（重写）

b：base（父类）

父类的虚函数，在子类用override重写该函数，可以选择用/不用base。

用里氏替换或者其他方法声明对象，new什么就调用什么的方法ß

```csharp
namespace 多态_vob;

class GameObject
{
    public string name;
    public GameObject(string name)
    {
        this.name = name;
    }
    public virtual void Atk()
    {
        Console.WriteLine("GameObject对象的攻击");
    }
}
class Player : GameObject
{
    //子类默认找的是父类的无参构造函数，但是上面父类中已经有参构造，顶掉了无参构造
    //所以需要:base()继承构造函数
    public Player(string name) : base(name)
    {

    }
    //虚函数可以被子类重写
    public override void Atk()
    {
        //base.Atk();   //保留父类的虚函数行为，可以写在这个override方法的任何需要的地方
        Console.WriteLine("Player对象的攻击");
    }
}

class Program
{
    static void Main(string[] args)
    {
        GameObject p1 = new Player("sb");
        p1.Atk();
        //这就和原来用as的方式结果一样，但是可读性更强
        // (p1 as Player).Atk();
    }
}

```

#### 什么时候需要base？

需要保留父类行为就base.方法名()

> 习题

![1748268507365](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004208654-1776721813.png)

```csharp
using System.Drawing;

namespace 多态_vob习题;

//1
class Duck
{
    public virtual void Speak()
    {
        Console.WriteLine("嘎嘎叫");
    }
}
class woodenDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("吱吱叫");
    }
}
class rubberDuck : Duck
{
    public override void Speak()
    {
        Console.WriteLine("唧唧叫");
    }
}

//3
class Graph
{
    public virtual float area()
    {
        return 0;
    }
    public virtual float perimeter()
    {
        return 0;
    }
}
class Rectangle : Graph
{
    public float width, length;
    public Rectangle(float width, float length)
    {
        this.width = width;
        this.length = length;
    }
    public override float area()
    {
        return width * length;
    }
    public override float perimeter()
    {
        return 2 * (width + length);
    }
}
class Square : Graph
{
    public float sideLength;
    public Square(float sideLength)
    {
        this.sideLength = sideLength;
    }
    public override float area()
    {
        return sideLength * sideLength;
    }
    public override float perimeter()
    {
        return sideLength * 4;
    }
}
class Sphere : Graph
{
    public float radius;
    public Sphere(float radius)
    {
        this.radius = radius;
    }
    public override float area()
    {
        return radius * 3.14f * 3.14f;
    }
    public override float perimeter()
    {
        return radius * 2 * 3.14f;
    }  
}
class Program
{
    static void Main(string[] args)
    {
        //1
        Duck d1 = new Duck();
        d1.Speak();
        Duck w1 = new woodenDuck();
        w1.Speak();
        Duck r1 = new rubberDuck();
        r1.Speak();
        //3
        Graph rect1 = new Rectangle(1, 2);
        Console.WriteLine(rect1.area());
        Console.WriteLine(rect1.perimeter());

        Graph square1 = new Square(1);
        Console.WriteLine(square1.area());
        Console.WriteLine(square1.perimeter());

        Graph sphere1 = new Sphere(1);
        Console.WriteLine(sphere1.area());
        Console.WriteLine(sphere1.perimeter());
    }
}

```

### 抽象类和抽象函数

#### 抽象类

关键字：`abstract`

特点：

1. **不能被实例化**，但是可以用里氏替换原则作为容器存储对象
2. 可以包含抽象方法
3. 继承抽象类必须重写他的抽象方法

```csharp
namespace 多态_抽象类和抽象函数;

abstract class Thing
{
    public string name;
    //抽象函数

}
class Water : Thing
{
  
}
class Program
{
    static void Main(string[] args)
    {
        //抽象类不能被实例化
        //  Thing t = new Thing();  // 错误
        //抽象类的子类可以用里氏替换原则用父类装子类
        Thing t = new Water();
        //抽象类的子类可以被实例化
        Water w = new Water();
    }
}

```

#### 抽象函数

又名：纯虚方法

关键字：abstarct

特点：

1. 只能在抽象类中申明
2. 没有函数体，就是不要写花括号{}
3. 不能是私有的
4. 继承后必须用override重写

```csharp
abstract class Thing
{
    public string name;
    //抽象函数
    public abstract void Show();
    //虚函数
    public virtual void Test()
    {
  
    }
}
class Water : Thing
{
    //继承一个有抽象函数的抽象类，必须要实现抽象函数
    public override void Show()
    {

    }
    //虚函数可以选择是否要覆盖
    public override void Test()
    {

    }
}
```

##### 抽象函数和虚函数的区别

抽象函数：父类里面一定不能有函数体，只能在抽象类里申明，必须要在其子类里实现，但在子类的子类就可以不用实现了

虚函数：可以选择在父类中写不写函数体，可以在任意类申明，可以选择在子类是否重写

##### 抽象函数和虚函数的共同点

都可以在子类/子类的子类无限重写

> 习题

![1748357566289](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004209555-925458747.png)

```csharp
namespace 多态_抽象类和抽象函数习题;

//1.
abstract class Animal
{
    public abstract void Speak();
}
class Person : Animal
{
    public override void Speak()
    {
        Console.WriteLine("人叫");
    }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("狗叫");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("猫叫");
    }
}

//2.
abstract class Graph
{
    public abstract float area();
    public abstract float perimeter();
}
class Rectangle : Graph
{
    public float width, length;
    public Rectangle(float width, float length)
    {
        this.width = width;
        this.length = length;
    }
    public override float area()
    {
        return width * length;
    }
    public override float perimeter()
    {
        return 2 * (width + length);
    }
}
class Square : Graph
{
    public float sideLength;
    public Square(float sideLength)
    {
        this.sideLength = sideLength;
    }
    public override float area()
    {
        return sideLength * sideLength;
    }
    public override float perimeter()
    {
        return 4 * sideLength;
    }
}
class Circle : Graph
{
    public float radius;
    public Circle(float radius)
    {
        this.radius = radius;
    }
    public override float area()
    {
        return 3.14f * radius * radius;
    }
    public override float perimeter()
    {
        return 2 * 3.14f * radius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //1.
        Animal[] animals = new Animal[3] { new Dog(), new Cat(), new Dog() };
        foreach (Animal a in animals)
        {
            a.Speak();
        }

        //2.
        Graph[] graphs = new Graph[3] { new Rectangle(1, 2), new Square(2), new Circle(2) };
        foreach (Graph g in graphs)
        {
            Console.WriteLine(g.GetType().Name + "面积：" + g.area());
            Console.WriteLine(g.GetType().Name + "周长：" + g.perimeter());
        }

    }
}

```

### 接口

*——接口就是抽象出来的一种行为父类，不同类的子类都可以继承这个接口*

> 比如鸟和飞机，分别是动物类的子类和机器的子类，但是都有飞这个行为，就可以抽象出来一个接口：IFly

关键字：`interface`

接口是行为的抽象规范，是一种自定义类型。

特点：

* 接口和类的申明相似
* 接口是用来继承的
* 接口不能被实例化，但是可以用里氏替换原则作为容器存储对象

#### 接口的申明

**接口是抽象行为的父类**

**接口命名**：帕斯卡命名法前加一个“ I "

接口申明的规范：

1. 不包含成员变量
2. 只包含方法、属性、索引器、事件
3. 成员不能被实现
4. 成员可以不用写访问修饰符，但绝对不能是私有的
5. 接口不能继承于类，但是可以继承另一个接口

```csharp
interface IFly
{
    //接口不能包含成员变量
    //  int a; //错误

    //方法
    void Fly();

    //属性
    string Name { get; set; }

    //索引器
    int this[int index] { get; set; }

    //事件
    event Action doSomething;
}
```

#### 接口的使用

接口的使用规范：

1. 接口是用来继承的
2. 类可以继承1个类，n个接口
3. 接口本身可以不用写访问修饰符，默认就是public
4. **继承了接口后，必须实现接口中的所有成员，并且必须用public**(如果用protected，那就必须显示实现)

```csharp
//接口的使用
class Animal
{

}
class Person : Animal, IFly
{
    //实现接口中的函数，可以申明为虚函数virtual，在子类中重写
    public virtual void Fly()
    {

    }
    public string Name { get; set; }

    public int this[int index]
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }
    public event Action doSomething;
}

```

接口遵循里氏替换原则

```csharp
class Program
{
    static void Main(string[] args)
    {
        //接口不能实例化
        //  IFly f = new IFly();    //错误
        //接口可以作为容器，里氏替换原则
        IFly f = new Person();

    }
}
```

#### 接口可以继承接口

1. 接口继承接口后，不需要实现
2. 类继承接口后，类必须实现所有内容

```csharp
//接口继承接口
interface IWalk
{
    void Walk();
}
//接口继承接口，不需要实现
interface IMove : IWalk, IFly
{

}
//类继承接口，必须实现所有成员
class Test : IMove
{
    public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event Action doSomething;

    public void Fly()
    {

    }

    public void Walk()
    {

    } 
}
```

里氏替换，接口作为容器

```csharp
        IMove im = new Test();
        IFly ifly = new Test();
        IWalk iw = new Test();
        //用什么接口装，其对象就只能是该接口含有的方法
        im.Walk();
        im.Fly();
        //IFly只有Fly()
        ifly.Fly();
        //IWalk只有Walk()
        iw.Walk();
```

#### 显示实现接口

当一个类继承2个接口，但是接口存在同名方法时

显示实现接口不能写访问修饰符

```csharp
//显示实现接口
interface IAtk
{
    void Atk();
}
interface ISuperAtk
{
    void Atk();
}
class Player : IAtk, ISuperAtk
{
    //继承接口的方法
    //类继承接口时，不加public，就必须要显示实现接口中的方法
    //接口名.方法名
    void IAtk.Atk()
    {

    }
    void ISuperAtk.Atk()
    {

    }
    //玩家自身的方法
    public void Atk()
    {

    }
}

```

```csharp
        //显示实现的使用
        IAtk ia = new Player();
        ISuperAtk isa = new Player();
        ia.Atk();
        isa.Atk();

        Player p = new Player();
        (p as IAtk).Atk();
        (p as ISuperAtk).Atk();
        p.Atk();
```

#### 总结

* 继承类：是对象间的继承
* 继承接口：行为间的继承，继承接口里的行为规范去实现内容

接口可以作为容器装对象

接口的引入，可以实现装载各种不同类但是有相同行为的对象

特别注意：

* 接口包含 成员方法、属性、索引器、事件，并且都不实现，都没有访问修饰符
* 可以继承多个接口，但只能继承一个类
* 接口可以继承接口，这就相当于行为的合并，在子类继承的时候再去实现具体的行为
* 接口可以被显示实现，用来解决不同接口中的同名函数的不同实现
* 接口方法在子类实现的时候可以加virtual申明为虚函数，然后在之后的子类中重写

> 习题

![1748450451796](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250529004211638-1168007505.png)

```csharp
namespace 多态_接口习题;

//1.
interface IRegister
{
    void Register();
}
class Person : IRegister
{
    public void Register()
    {
        Console.WriteLine("在派出所登记");
    }
}
class Car : IRegister
{
    public void Register()
    {
        Console.WriteLine("在车管所登记");
    }
}
class House : IRegister
{
    public void Register()
    {
        Console.WriteLine("在房管局登记");
    }
}

//2.
abstract class Animal
{
    public abstract void Walk();
}
interface IFly
{
    void Fly();
}
interface ISwim
{
    void Swim();
}
class helicopter : IFly
{
    public void Fly()
    {
        Console.WriteLine("直升机开始飞");
    }
}
class sparrow : Animal, IFly
{
    public override void Walk()
    {
    }
    public void Fly()
    {
    }
}
class Ostrich : Animal
{
    public override void Walk()
    {
    }
}
class Penguin : Animal, ISwim
{
    public void Swim()
    {
    }
    public override void Walk()
    {
    }
}
class Parrot : Animal, IFly
{
    public void Fly()
    {
    }
    public override void Walk()
    {
    }
}
class Swan : Animal, ISwim,IFly
{
    public void Swim()
    {
    }
    public void Fly()
    {
    }
    public override void Walk()
    {
    }
}

//3.
interface IUSB
{
    void ReadData();
}
class Computer
{
    public IUSB usb1;
}
class StorageDevice : IUSB
{
    public string name;
    public StorageDevice(string name)
    {
        this.name = name;
    }
    public void ReadData()
    {
        Console.WriteLine(name + "读取数据");
    }
}
class Mp3 : IUSB
{
    public void ReadData()
    {
        Console.WriteLine("mp3读取数据");
    }
}



class Program
{
    static void Main(string[] args)
    {
        //1.
        IRegister[] arr = new IRegister[] { new Person(), new Car(), new House() };
        foreach (IRegister item in arr)
        {
            item.Register();
        }

        //3.
        Computer cp1 = new Computer();
        cp1.usb1 = new Mp3();
        cp1.usb1.ReadData();
        cp1.usb1 = new StorageDevice("硬盘");
        cp1.usb1.ReadData();
    }
}

```

### 密封方法

关键字：`consealed`

子类对虚函数和抽象函数override的时候加上了关键字sealed，那么在这个子类的子类就不能再重写了。

特点：

* 密封方法可以让虚函数和抽象函数不能再次被子类重写
* 和override一起出现

```csharp
abstract class Animal
{
    public string name;
    public abstract void Atk();
    public virtual void Fuck()
    {
        Console.WriteLine("fuck");
    }
}
class Person : Animal
{
    public sealed override void Atk()
    {
    }
    public sealed override void Fuck()
    {
        Console.WriteLine("fuck me");
    }
}
// class Test : Person
// {
//     //后续子类就不能重写了
//     public override void Atk()
//     {
//     }
//     public override void Fuck()
//     {
//     }
// }
```

## 命名空间

作用：用来组织和复用代码

> 命名空间：工具包，类：工具包里面的一个个工具(申明在命名空间中)

### 使用

命名空间可以同名，也就是分段写，也可以分文件写

```csharp
namespace MyGame
{
    class GameObject
    {
    }
}
namespace MyGame
{
    class Player : GameObject
    {
    }
}
```

### 不同命名空间中互相使用：需要引用命名空间/指明出处

1. using 命名空间名;

```csharp
using MyGame;

namespace 命名空间
{
    class Program
    {
        static void Main()
        {
            //不同命名空间中相互使用，需要引用命名空间或指明出处
            GameObject g = new GameObject();
        }
    }
}

```

2. 命名空间名.类名

```csharp
            //不同命名空间中相互使用，需要引用命名空间或指明出处
            MyGame.GameObject g = new MyGame.GameObject();
```

### 不同命名空间中允许有同名类

```csharp
namespace MyGame
{
    class GameObject
    {
    }
}
//不同命名空间允许有同名的类
namespace MyGame2
{
    class GameObject
    {
    }
}
```

如果要在另一个命名空间调用不同命名空间的同名类，只能必须指明出处

```csharp
            MyGame.GameObject g = new MyGame.GameObject();
            MyGame2.GameObject g2 = new MyGame2.GameObject();
```

### 命名空间可以包裹命名空间

也就是命名空间里细分命名空间

```csharp
namespace MyGame
{
    namespace UI
    {

    }
    namespace Game
    {
  
    }
}
```

调用的时候一层层点就行，或者引用命名空间using MyGame.UI

### 修饰类的访问修饰符

public	默认公开

internal	只能在该程序集里用

abstract	抽象类

sealed	密封类

partial	分部类

## 万物之父中的方法

### object中的静态方法

#### Equals()

作用：判断两个对象是否相等，比较的是二者指向的内存地址是否一样

最终判断权交给左侧对象的Equals方法

```csharp
        //Equals()
        //比较的是二者指向的内存地址是否一样
        //最终判断权交给左侧对象的Equals方法
        //值类型
        Console.WriteLine(Object.Equals(1, 1));
        Console.WriteLine(1.Equals(1));
        //引用类型
        Test t1 = new Test();
        Test t2 = new Test();
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));
        t2 = t1;
        Console.WriteLine(Object.Equals(t1, t2));
        Console.WriteLine(t1.Equals(t2));
```

#### ReferenceEquals()

作用：比较两个对象是否是相同的引用(内存地址)

```csharp
        //ReferenceEquals()
        //比较两个对象是否是相同的引用(内存地址)
        //值类型：返回值永远是flase
        Console.WriteLine(Object.ReferenceEquals(1, 1));
        //引用类型：
        Test t3 = new Test();
        Test t4 = new Test();
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
        t4 = t3;
        Console.WriteLine(Object.ReferenceEquals(t3, t4));
```

object可以省略，因为是万物之父，只要在类里，这个类肯定继承于Object，所以也包含这个方法

### object中的成员方法

#### 普通方法GetType()

作用：获取对象运行时的类型Type，返回一个Type类型的对象

通过Type结合后面的反射相关特性，可以做很多关于对象的操作

```csharp
        //普通方法Type()
        Test t5 = new Test();
        Type type = t5.GetType();
```

#### 普通方法MemberwiseClone()

作用：获取对象的浅拷贝对象，返回一个新的对象。

但是新对象(克隆体)的引用变量改了之后，老对象相应的引用变量也会改变

```csharp
class Test
{
    //值类型成员变量
    public int i = 1;
    //引用类型成员变量
    public Test2 ttt = new Test2();
    public Test Clone()
    {
        return MemberwiseClone() as Test;
    }
}
class Test2
{
    public int i = 2;
}
```

```csharp
        //普通方法MemberwiseClone()
        Test t_2 = t.Clone();
        Console.WriteLine("克隆对象后");
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
        Console.WriteLine("改变克隆对象的信息");
        t_2.i = 99;
        t_2.ttt.i = 100;
        Console.WriteLine("t.i = " + t.i);
        Console.WriteLine("t.ttt.i = " + t.ttt.i);
        Console.WriteLine("t_2.i = " + t_2.i);
        Console.WriteLine("t_2.ttt.i = " + t_2.ttt.i);
```

![1748530266350](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101100567-1717636512.png)

### object中的虚函数方法

#### 虚函数Equals()

默认实现还是比较二者是否为同一个引用，等同于ReferenceEquals()

但是微软在所有值类型的基类System.ValueType中重写了Equals()，用来比较值相等

**我们也可以对Equals()进行重写**

#### 虚函数GetHashCode()

作用：获取对象的哈希码

可以重写

#### 虚函数ToString()

作用：返回当前对象的字符串

可重写

当调用打印方法，默认会使用ToString()

> 习题

![1748563698568](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101101373-33714842.png)

```csharp
namespace 万物之父中的方法习题;

//1.
class Player
{
    private string name;
    private int hp;
    private int atk;
    private int def;
    private int miss;
    public Player(string name, int hp, int atk, int def, int miss)
    {
        this.name = name;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.miss = miss;
    }
    public override string ToString()
    {
        return String.Format("姓名{0},血量{1},攻击{2},防御{3},闪避{4}", name, hp, atk, def, miss);
    }
}

//2.
class Monster
{
    public Monster m;
    public string Name { get; set; }
    public int Hp{  get; set; }
    public int Atk{  get; set; }
    public int Def{  get; set; }
    public int SkillID{  get; set; }
    public Monster(string name, int hp, int atk, int def, int skillID)
    {
        Name = name;
        Hp = hp;
        Atk = atk;
        Def = def;
        SkillID = skillID;
        m = this;
    }
    public Monster Clone()
    {
        return MemberwiseClone() as Monster;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //1.
        Player p = new Player("张三", 100, 10, 5, 5);
        Console.WriteLine(p);

        //2.
        Monster A = new Monster("A", 100, 10, 5, 5);
        Monster B = A.Clone();
        B.Name = "B";
        Console.WriteLine(A.Name);
        //因为是值类型的，所以改克隆体不会改变原来的值
        B.m.Name = "B";
        Console.WriteLine(A.m.Name);
        //引用类型的内容改变，改克隆体，原来的值也会改变
    }
}

```

## String

### 获取字符串指定位置字符

字符串本质是char的数组

可以直接用索引器，或ToCharArray()转成数组后再索引

```csharp
        //字符串获取指定位置字符
        string str = "hello world";
        Console.WriteLine(str[0]);
        //ToCharArray()：转成char数组
        char[] chars = str.ToCharArray();
        Console.WriteLine(chars[0]);
```

### 字符串拼接

string.Format()

```csharp
        //字符串拼接
        //  str = string.Format(str, "1");  //错误用法
        str = string.Format("{0}111",str);  //必须用占位符的形式
        Console.WriteLine(str);
```

### 正向查找字符位置

IndexOf()

```csharp
        //正向查找字符位置
        //找不到返回-1
        int index = str.IndexOf("o");
        Console.WriteLine(index);
        //忽略大小写,StringComparison.OrdinalIgnoreCase
        index = str.IndexOf("o",StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(index);
```

### 反向查找字符位置

LastIndexOf()

返回值：最后一次出现的起始索引位置

> 这个索引值还是从前往后的
>
> 反向体现在返回值是最后一次出现的起始索引位置

```csharp
        //反向查找字符位置
        //返回值 最后一次出现的起始索引位置
        int lastIndex = str.LastIndexOf("o");
        Console.WriteLine(lastIndex);
        //找最后一次出现目标字符串的第一个字符的位置
        lastIndex = str.LastIndexOf("d111");
        Console.WriteLine(lastIndex);
```

### 移除指定位置后的字符

Remove()

```csharp
        //移除指定位置后的字符(含指定位置一起移除)
        string str1 = str.Remove(2);
        Console.WriteLine(str1);
        //移除[开始位置,开始位置+count]的字符
        //第二个参数，count
        str1 = str.Remove(2, 3);
        Console.WriteLine(str1);
```

### 字符串替换

Replace()

```csharp
        //字符串替换
        str = str.Replace("hello", "FUCK");
        Console.WriteLine(str);
```

### 大小写转换

ToUpper()

ToLower()

```csharp
        //大小写转换
        str = str.ToUpper();
        Console.WriteLine(str);
        str = str.ToLower();
        Console.WriteLine(str);
```

### 字符串截取

Substring()

```csharp
        //字符串截取
        //截取指定位置开始之后的字符串(含指定位置)
        str1 = str.Substring(1);
        Console.WriteLine(str1);
        //截取[开始位置,开始位置+count]
        str1 = str.Substring(1, 3);
        Console.WriteLine(str1); 
```

### 字符串切割

Split()

```csharp
        //字符串切割
        str = "1_1 | 1_2 | 1_3 | 1_4 | 1_5";
        string[] strs = str.Split(" | ");
        for (int i = 0; i < strs.Length; i++)
        {
            //[1]：取切割符串后的字符串
            strs[i] = strs[i].Split("_")[1];
            Console.WriteLine(strs[i]);
        }
```

> 习题

![1748568223999](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530101102253-662457769.png)

```csharp
//1.
//  SubString
//  Replace

//2.
string str = "1|2|3|4|5|6|7";
string[] strs = str.Split('|');
str = "";
for (int i = 0; i < strs.Length; i++)
{
    str += int.Parse(strs[i]) + 1;
    if (i != strs.Length - 1) str += "|";
}
Console.WriteLine(str);

//3.
//别名

//4.
//3个堆空间
//str = "123";
//str2 = "321";
//str2 += "123";
//只要重新赋值string就会重新分配内存

//5.
string str2 = "hello";
char[] str2s = str2.ToCharArray();
for (int i = 0; i < str2.Length / 2; i++)
{
    str2s[i] = (char)(str2s[i] + str2s[str2.Length - 1 - i]);
    str2s[str2.Length - 1 - i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
    str2s[i] = (char)(str2s[i] - str2s[str2.Length - 1 - i]);
}
foreach (char c in str2s) Console.Write(c);
Console.WriteLine();

```

## StringBuilder

一个用于处理字符串的公共类

作用：修改字符串而不用每次都创建新的对象

对于需要频繁修改和拼接的字符串可以使用它，用来提升性能，因为每次创建新的对象都会加快gc的到来

使用前需要using 命名空间：`using System.Text;`

### 申明

```csharp
using System.Text;

//第二个参数：初始化容量，设定过大会浪费空间
//在后续每次往里增加内容，会自动扩容
StringBuilder str = new StringBuilder("123123",100);
Console.WriteLine(str);
Console.WriteLine(str.Capacity);
```

### 增删查改替换

```csharp
//增删查改替换

//增
//不能用+=，用Append()和AppendFormat()
str.Append("111");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);
str.AppendFormat("{0}{1}", "222", "333");
Console.WriteLine(str);
Console.WriteLine(str.Length);
Console.WriteLine(str.Capacity);

//插入
str.Insert(0, "FUCK");
Console.WriteLine(str);

//删
//Remove(开始位置，count)
str.Remove(0, 4);
Console.WriteLine(str);

//清空
// str.Clear();
// Console.WriteLine(str);

//查
//  索引器
Console.WriteLine(str[1]);

//改
//  之前的string是只读不可改的，现在的StringBuilder是可改的
str[1] = 'f';
Console.WriteLine(str);

//替换
//  只替换第一个匹配项
str.Replace("123", "FUCK");
Console.WriteLine(str);

//Equals()
str.Clear();
str.Append("111");
if (str.Equals("111"))
{
    Console.WriteLine("相等");
}
```

> 习题

![1748609786046](https://img2023.cnblogs.com/blog/3614909/202505/3614909-20250530215810005-621816605.png)

//1.

string每次改动都会创建一个新的对象，也就更容易产生垃圾，更容易触发gc

stringbuilder因为有初始容量的存在，只有达到初始容量上限才会扩容

string更加灵活，内置方法更多：IndexOf()、LastIndexOf()、ToUpper()、ToLower()、Substring()、Split()

stringbuilder适合需要频繁改动的字符串

//2.

> 就目前已学知识

如何节约内存：少new对象、合理使用static

如何尽可能的减少gc：合理使用string和stringbuilder

## 结构体和类的区别(面试常考)

1. 存储空间：结构体是值，在栈上；类是引用，在堆上
2. 使用：结构体不具备继承和多态的特性，只有封装的思想，也不能使用protected保护成员变量

### 详细对比：

| 结构体                                                             | 类       |
| ------------------------------------------------------------------ | -------- |
| 值类型                                                             | 引用类型 |
| 栈内存                                                             | 堆内存   |
| 不能用protected                                                    | 可以     |
| 结构体成员变量的申明不能设定初始值                                 | 可以     |
| 结构体不能自己申明无参构造函数，因为自带                           | 可以     |
| 结构体申明有参构造函数时，无参构造函数不会被顶掉                   | 会被顶掉 |
| 结构体不能申明析构函数                                             | 可以     |
| 结构体不能被继承                                                   | 可以     |
| **结构体需要在构造函数中初始化所有成员变量**                 | 随意     |
| 结构体不能被static修饰(不存在静态结构体)，但是结构体可以有静态成员 | 可以     |
| 结构体不能在内部申明和自己一样的结构体变量                         | 可以     |

对于最后一点：C# 的结构体是值类型，**不允许结构体中直接包含自身类型字段**

**C / C++：允许使用指针实现自引用结构体**

```csharp
struct Node {
    int value;
    struct Node* next; // ✅ C / C++允许：使用指针实现自引用
};
```

不能直接嵌套自身类型：

```csharp
struct Node {
    int value;
    struct Node next; // ❌ 错误：会导致无限大小的结构体
};
```

### 结构体的特别之处

结构体可以继承接口，但是结构体不能继承结构体和类

### 如何选择：结构体or类？

当需要继承和多态，只能用类(玩家、怪物)

当对象是数据集合，优先考虑结构体(位置、坐标)

从值和引用类型的赋值上的区别考虑：

因为结构体是值类型，所以当对象经常需要被赋值传递，但是又不希望原对象被改变，就用结构体。(坐标、向量、旋转)

## 抽象类和接口的区别(面试常考)

抽象类：abstract，不能实例化，抽象函数只能在抽象类里面申明，是个纯虚函数，必须在子类中实现

接口：interface，是行为的抽象，不能实例化，但是可以作为容器，不含成员变量，只有方法、属性、索引器、事件， 这些成员都不能实现，最好不要写访问修饰符，默认public，避免显示实现(接口名.方法名)

### 相同点

都可以被继承

都不能直接实例化

都可以包含方法等的申明

其子类必须实现

遵循里氏替换原则

### 不同点

| 抽象类                                                               | 接口                                                                  |
| -------------------------------------------------------------------- | --------------------------------------------------------------------- |
| 可以有构造函数                                                       | 没有                                                                  |
| 只能被单一继承<br />这是类的通性，只能继承一个父类和但是可以多个接口 | 可以被继承多个                                                        |
| 有成员变量                                                           | 没有                                                                  |
| 可以申明成员方法、虚函数、抽象函数、静态函数                         | 只能申明没有实现的函数                                                |
| 可以使用访问修饰符                                                   | 最好不写，默认为public<br />(否则就要在子类中显示实现：接口名.方法名) |

### 如何选择抽象类和接口

抽象出来的对象，用抽象类

一个规范行为，用接口

不同对象的共有行为，用接口

> OVER~

# C#进阶篇

![1748674622387](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250605203740579-1632264547.png)

## 简单数据结构类

### ArrayList

Object类型的数组

#### 申明

```csharp
        //ArrayList的申明
        ArrayList arr1 = new ArrayList();
```

#### 增删查改

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

#### 排序和反转

和数组一样

```csharp
arr1.Sort();
arr1.Reverse();
```

#### 装箱拆箱

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

#### ArrayList和数组的区别

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

### Stack

本质是object[]数组

栈储存容器，后进先出

#### 栈的使用

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

#### 栈的装箱拆箱

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

#### 栈的应用

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

### Queue

本质是object[]数组，先进先出，类似管道

#### 队列的使用

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

#### 队列的装箱拆箱

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

### Hashtable

哈希表/散列表，本质是一个字典

是基于键的哈希代码组织起来的键值对 `<key,value>`

用键来访问集合中的元素

#### 哈希表的使用

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

#### 哈希表的装箱拆箱

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

## 泛型

### 泛型的基本概念

* 泛型实现了**类型参数化**，用于代码复用
* 通过类型参数化来实现在同一份代码上操作多种类型
* **相当于类型占位符**
* 定义类/方法的时候使用替代符来来代表变量类型
* **当真正使用类和方法时再具体制定类型**
* 泛型占位符一般用大写字母

#### 泛型的作用

1. 不同类型对象的相同逻辑处理，可以选择泛型，提升代码的复用
2. 使用泛型，可以一定程度**避免装箱拆箱**
3. eg：自己写泛型类ArrayList `<T>`来解决ArrayList存在的装箱拆箱问题、Stack `<Type>`、Queue `<Type>`、用字典 `Dictionary<T1,T2>`实现Hashtable

#### 泛型分类

##### 语法

泛型类：		class 类名<泛型占位字母>

泛型接口：	interface 接口名<泛型占位字母>

泛型函数：	函数名<泛型占位字母>

泛型占位字母可以有多个，用逗号隔开

##### 泛型类

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

##### 泛型接口

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

##### 泛型方法(函数)

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

##### 泛型类中的泛型方法

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

![1749802246428](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250623014931577-99512411.png)

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

### 泛型约束

#### 泛型约束的基本概念

`where 泛型字母:(约束的类型)`

* 让泛型的类型有一定限制
* 关键字：`where`
* 泛型约束一共有6种

#### 各泛型约束

| 值类型                        | `where 泛型字母:struct`     |
| :---------------------------- | :---------------------------- |
| 引用类型                      | where 泛型字母:class          |
| 存在无参公共构造函数          | where 泛型字母:new()          |
| 类本身/子类                   | where 泛型字母:类名           |
| 接口本身/接口的子类           | where 泛型字母:接口名         |
| 另一个泛型类型本身/其派生类型 | where 泛型字母:另一个泛型字母 |

```csharp
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

    }
}

```

#### 约束的组合使用

用 `逗号`连接两个约束，相当于多个约束条件

注意：

* 但不是每个都能组合起来使用，看报错
* new()一般写在最后

```csharp
#region 约束的组合使用
//同时是引用类型且必须有无参构造函数
class Test8<T> where T : class, new()
{

}
class Test8_
{
  
}
#endregion
```

```csharp
        #region 约束的组合使用
        Test8<Test8_> t14 = new Test8<Test8_>();
  
        #endregion
```

#### 多个泛型有约束

每个泛型字母都要对应一个 `where`

```csharp
#region 多个泛型有约束
class Test9<T,U> where T : class, new() where U : struct
{

}
#endregion
```

> 习题

![1750478791617](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250623014933068-890493494.png)

```csharp
namespace 泛型约束习题;

//1. 泛型实现单例模式
class SingleBase<T> where T : new()
{
    private static T _instance = new T();
    public static T Instance
    {
        get
        {
            return _instance;
        }
    }
}

class Test : SingleBase<Test>
{
  
}

//2. 泛型实现一个不确定类型的ArrayList
class ArrayList<T>
{
    private T[] array;
    public void Add(T value)
    {
        //...
    }
    public void RemoveAt(int index)
    {
        //...
    }
    public void Remove(T value)
    {
        //...
    }
    public T this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value;
        }
    }
}

```

## 常用泛型数据结构类型

### List——列表，泛型ArrayList

本质：一个可变类型的泛型数组，也就是泛型实现的ArrayList

类型在申明时就确定好，所以不存在装箱拆箱

#### List的申明

```csharp
using System.Collections.Generic;

//申明
List<int> list = new List<int>();
```

#### List的增删查改遍历

和ArrayList一样

```csharp
using System.Collections.Generic;

//申明
List<int> list = new List<int>();

//增删查改

#region 增
//单个加
list.Add(1);
list.Add(2);

List<int> list2 = new List<int>();
list2.Add(1);
//范围加
list.AddRange(list2);
//在指定位置插入
list.Insert(0, 999);
#endregion

#region 删
//移除指定元素
list.Remove(1);
//移除指定位置元素
list.RemoveAt(0);
//清空
list.Clear();
#endregion

list.Add(1);
list.Add(2);
list.Add(3);

#region 查
//得到指定位置元素
Console.WriteLine(list[0]);
//元素是否存在
Console.WriteLine(list.Contains(1));
//正向查找元素位置
//找不到返回-1
Console.WriteLine(list.IndexOf(1));
Console.WriteLine(list.IndexOf(0));
//反向查找元素位置,返回的也是从左往右数的位置，只是从末尾开始遍历
//找不到返回-1
Console.WriteLine(list.LastIndexOf(1));
Console.WriteLine(list.LastIndexOf(0));
#endregion

#region 改
list[0] = 999;

#endregion

Console.WriteLine();
#region 遍历
Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
foreach (var item in list)
{
    Console.WriteLine(item);
}
#endregion
```

#### List和ArrayList的区别

List就是在申明时就确定好类型的ArrayList

|          | List                         | ArrayList  |
| -------- | ---------------------------- | ---------- |
| 内部封装 | 泛型数组<br />不存在装箱拆箱 | object数组 |

### Dictionary——字典，泛型哈希表

本质：泛型实现的Hashtable，也是基于键的哈希代码组织起来的键值对

键值对的类型在申明时就确定好，所以不存在装箱拆箱

#### Dictionary的申明

```csharp
using System.Collections.Generic;

//申明
Dictionary<int, string> dictionary = new Dictionary<int, string>();
```

#### Dictionary的增删查改遍历

```csharp
using System.Collections.Generic;

//申明
Dictionary<int, string> dictionary = new Dictionary<int, string>();

//增删查改

#region 增
dictionary.Add(1, "111");
dictionary[2] = "222";
#endregion

#region 删
//1.通过键删除
//删除不存在的键，不报错
dictionary.Remove(1);
//2.清空
dictionary.Clear();
#endregion

dictionary.Add(1, "111");
dictionary.Add(2, "222");
dictionary.Add(3, "333");

#region 查
//1.通过键查询
//找不到键就报错，不返回空
Console.WriteLine(dictionary[1]);
//2.查看是否存在
//根据key
Console.WriteLine(dictionary.ContainsKey(1));  
//根据value
Console.WriteLine(dictionary.ContainsValue("222"));
#endregion

#region 改
dictionary[2] = "9999";
#endregion

//遍历
Console.WriteLine(dictionary.Count);
//一起遍历
foreach (var item in dictionary)
{
    Console.WriteLine(item.Key + ":" + item.Value);
}
foreach (KeyValuePair<int,string> item in dictionary)
{
    Console.WriteLine(item);
}
//遍历key
foreach (var item in dictionary.Keys)
{
    Console.WriteLine(item);
}
//遍历value
foreach (var item in dictionary.Values)
{
    Console.WriteLine(item);
}
```

### 顺序存储和链式存储

顺序结构：数组、ArrayList、Stack、Queue、List

链式结构：链表(单向、双向、循环)

### LinkedList——泛型双向链表

本质：一个可变类型的**泛型双向链表**

链表的节点类LinkedListNode `<T>`

![1750594295627](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250623014934295-596253269.png)

#### LinkedList申明

```csharp
//申明
LinkedList<int> linkedList = new LinkedList<int>();
LinkedList<string> linkedList2 = new LinkedList<string>();
```

#### LinkedList的增删查改和遍历

```csharp
//申明
LinkedList<int> linkedList = new LinkedList<int>();
LinkedList<string> linkedList2 = new LinkedList<string>();

//增删查改
#region 增
//头插
linkedList.AddFirst(1);
//尾插
linkedList.AddLast(99);
//在指定节点后插入
LinkedListNode<int> n = linkedList.Find(1);
linkedList.AddAfter(n, 2);
//在指定节点前插入
linkedList.AddBefore(n, 0);

#endregion

#region 删
//删除头节点
linkedList.RemoveFirst();
//删除尾节点
linkedList.RemoveLast();
//删除指定值的节点
//无法通过位置删除，因为链表没有办法直接获取索引
linkedList.Remove(99);
//清空
linkedList.Clear();
#endregion

linkedList.AddLast(1);
linkedList.AddLast(2);

#region 查
//获取头节点
LinkedListNode<int> first = linkedList.First;
//获取尾节点
LinkedListNode<int> last = linkedList.Last;
//获取指定值的节点
LinkedListNode<int> node = linkedList.Find(1);
Console.WriteLine(node.Value);
//判断是否存在
Console.WriteLine(linkedList.Contains(1));
#endregion

#region 改
Console.WriteLine(node.Value);
node.Value = 3;
Console.WriteLine(node.Value);
#endregion

#region 遍历
//迭代器
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
//通过节点遍历：因为本质是双向链表，所以存在正序和倒序遍历
//1.正序遍历
LinkedListNode<int> nowNode = linkedList.First;
while (nowNode != null)
{
    Console.WriteLine(nowNode.Value);
    nowNode = nowNode.Next;
}
//2.倒序遍历
nowNode = linkedList.Last;
while (nowNode != null)
{
    Console.WriteLine(nowNode.Value);
    nowNode = nowNode.Previous;
}
#endregion
```

### 泛型栈和队列

前面介绍栈和队列的时候有**装箱拆箱**的问题，在其解决方法中我已提过引入泛型来解决

#### 泛型栈

`Stack `

```csharp
Stack<int> stack = new Stack<int>();
```

#### 泛型队列

`Queue <T> queue`

```csharp
Queue<int> queue = new Queue<int>();
```

其内置方法和之前的栈和队列完全一样

## 总结：上述各种数据容器的适用场景

> 数组、List、Dictionary, Stack, Queue, LinkedList

| 数据结构            | 类型       | 特点                                        | 适用场景                                                            |
| ------------------- | ---------- | ------------------------------------------- | ------------------------------------------------------------------- |
| `数组`            | 固定长度   | 连续内存存储，支持下标访问，性能高          | 数据量固定、频繁通过下标访问的场景                                  |
| `List<T>`         | 动态数组   | 可变长度，支持下标访问，插入/删除效率较低   | 需要频繁修改内容但又需要通过索引快速查找的场景                      |
| `LinkedList<T>`   | 双向链表   | 插入/删除效率高，不支持下标访问             | 不确定长度，频繁在中间插入或删除元素的场景                          |
| `Stack<T>`        | 后进先出   | 入栈（Push）、出栈（Pop）、查看栈顶（Peek） | 实现递归算法、撤销/重做机制、UI面板显隐规则等                       |
| `Queue<T>`        | 先进先出   | 入队（Enqueue）、出队（Dequeue）            | 消息队列、任务调度、事件处理等需按顺序处理的场景                    |
| `Dictionary<K,V>` | 键值对集合 | 快速通过键查找值，不允许重复键              | 存储具有唯一标识的数据，如**ID-对象映射**、配置项、资源管理等 |

## 委托和事件

### 委托

委托是专门**装载函数**的容器，也就是函数的变量类型

用来存储、传递函数

**本质**：**是一个类**，用来定义函数的类型（返回值和参数的类型）

不同的函数对应和各自**“格式"一致的委托**

#### 委托的申明和使用

**关键字**：`delegate`

位置：nameplace、class语句块中，一般写在nameplace中

访问修饰符：一般用public，默认不写就是public

**语法**：`访问修饰符 delegate 返回值 委托名(参数列表)`

```csharp
namespace 委托;
//委托的申明，统一语句块中不能重名
delegate void MyFunc();
public delegate int MyFunc2(int a);

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

    }

    static void Fun()
    {
        Console.WriteLine("Fun");
    }
    static int Fun2(int value)
    {
        return value;
    }
}

```

#### 泛型委托

```csharp
//泛型委托
delegate T MyFunc3<T, K>(T t, K k);
```

#### 使用定义好的委托——观察者设计模式

```csharp
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
}
#endregion

class Program
{
    static void Main(string[] args)
    {
        #region 使用定义好的委托
        Test t = new Test();
        t.TestFunc(Fun, Fun2);
        #endregion
    }

    static void Fun()
    {
        Console.WriteLine("Fun");
    }
    static int Fun2(int value)
    {
        return value;
    }
}
```

#### 委托变量存储多个函数——加、减、清空

```csharp
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
```

```csharp
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

```

#### 系统定义好的委托

```csharp
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

```

```csharp
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

```

> 习题

![1750607172763](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250623014935494-945513101.png)

后面再来做题巩固

### 事件

事件是委托的安全包裹，让委托的使用更加安全

这是一种特殊的变量类型

**申明语法**：`访问修饰符 event 委托类型 事件名`

作用：

1. 作为成员变量存在于类、接口、结构体中
2. 委托怎么用，事件就怎么用

**事件和委托的区别**：事件不能在类的外部赋值、调用，**只能在内部封装起来调用，所以更安全**

#### 事件的申明

```
    //委托的申明
    public Action myFun;
    //事件的申明
    public event Action myEvent;
```

#### 事件的使用

```csharp
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

```

#### 总结：为什么要用事件？

1. 防止外部随意置空、调用委托
2. 事件相当于对委托又进行了一个封装，让他更加安全，只能在类的内部封装调用

> 习题

![1750662310381](https://img2023.cnblogs.com/blog/3614909/202506/3614909-20250623150530753-324510699.png)

### 匿名函数


### Lambda表达式

## 反射和特性

> 程序集：代码集合会被编译器编译为一个程序集，在windows中，就是后缀.dll库文件和.exe可执行文件

> 元数据：用来描述数据的数据。程序中的类，类中的成员 就是程序的元数据。

### 反射

**反射**：在程序运行时，通过反射可以得到其他或自身程序集代码的元数据。

——也就是通过反射可以得到类、函数、变量、对象，然后实例化、调用他们

反射的作用：

1. 反射可以在程序编译后获得信息，所以反射提高了程序的拓展性、灵活性
2. 程序运行时，可以得到所有元数据及其特性、可以实例化对象、操作对象、创建新对象

——也就是通过反射，可以直接去调用另一个程序集里写好的代码的各种信息

> 反射是unity脚本工作的基本原理

```csharp
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
```

#### Type——类的信息类

Type是反射的基础，是访问元数据的主要方式

使用Type的成员获取有关类型申明的信息(构造函数、方法、字段、属性、类的事件)

##### 三种获取Type的方式：

```csharp
        //获取Type：
        //  1.object中的.GetType()获取对象的Type
        int a = 42;
        Type type = a.GetType();
        Console.WriteLine(type);
        //  2.通过typeof关键字，传入类名，获取对象的Type
        Type type2 = typeof(int);
        Console.WriteLine(type2);
        //  3.通过类名，获取对象的Type
        Type type3 = Type.GetType("System.Int32");
        Console.WriteLine(type3);
```

每一个类型的Type是唯一的，所以虽然有三个Type变量来存，但这里指向堆内存里的地址是一样的

##### 获取类的程序集信息：

```csharp
        //得到类的程序集信息
        //  通过Type变量名.Assembly得到类型所在程序集信息
        Console.WriteLine(type.Assembly);
```

##### 获取类中的所有公共成员:

```csharp
        //获取类中的所有公共成员：
        //  先得到类的Type
        Type t = typeof(Test);
        //  用.GetMembers()获取类中的所有公共成员，需要先using System.Reflection;
        MemberInfo[] infos = t.GetMembers();
        foreach (var info in infos)
        {
            Console.WriteLine(info);
        }
```

##### 获取类的公共构造函数并调用：

```csharp
        //获取类的公共构造函数并调用：
        //  1.用.GetConstructors()获取所有构造函数
        ConstructorInfo[] cis = t.GetConstructors();
        foreach (var ci in cis)
        {
            Console.WriteLine(ci);
        }
        //  2.用GetConstructor()获取其中一个构造函数并用.Invoke()执行
        //步骤如下：
        //得构造函数，传入Type数组，数组中的内容按顺序填入typeof(构造函数参数类型)
        //执行构造函数，传入object数组，数组中按顺序传入参数
      
        //  无参构造
        //      得到无参构造，直接传参new Type[0]
        ConstructorInfo info1 = t.GetConstructor(new Type[0]);
        //      用.Invoke()执行无参构造，传参null
        Test obj = info1.Invoke(null) as Test;
        Console.WriteLine(obj.j);

        //  有参构造
        //      得到有参构造，直接传参new Type[]{typeof(int)}
        ConstructorInfo info2 = t.GetConstructor(new Type[] { typeof(int) });
        obj = info2.Invoke(new object[] { 1 }) as Test;
        Console.WriteLine(obj.str);

        ConstructorInfo info3 = t.GetConstructor(new Type[] { typeof(int), typeof(string) });
        obj = info3.Invoke(new object[] { 1, "fuck" }) as Test;
        Console.WriteLine(obj.str);
```

##### 获取类的公共成员变量：

```csharp
        //获取类的公共成员变量：
        //  1.用.GetFields()得到所有公共成员变量，存在FieldInfo[]数组中
        FieldInfo[] fields = t.GetFields();
        foreach (FieldInfo field in fields)
        {
            Console.WriteLine(field);
        }
        //  2.用.GetField("公共成员变量名")得到指定名称的公共成员变量，存在FieldInfo中
        FieldInfo infoJ = t.GetField("j");
        Console.WriteLine(infoJ);
        FieldInfo infoStr = t.GetField("str");
        Console.WriteLine(infoStr);

        //  3.通过反射获取和设置对象的值
        Test test = new Test();
        test.j = 99;
        test.str = "2222";
        //      通过反射，用 对象的某个成员变量名.GetValue(对象名) 获取对象的某个成员变量的值
        Console.WriteLine(infoJ.GetValue(test));
        //      通过反射，用 对象的某个成员变量名.SetValue(对象名, 要设置的值) 设置指定对象的某个成员变量的值
        infoJ.SetValue(test, 999);
        Console.WriteLine(infoJ.GetValue(test));
```

##### 获取类的公共成员方法：

```csharp
        //获取类的公共成员方法：
        //通过Type类的GetMethod()方法，获取类中的公共方法，存在MethodInfo中
        Type strType = typeof(string);
        MethodInfo[] methodInfos = strType.GetMethods();
        foreach (MethodInfo methodInfo in methodInfos)
        {
            Console.WriteLine(methodInfo);
        }
        //  1.如果有方法重载，用Type数组表示参数类型
        MethodInfo subStr = strType.GetMethod("Substring",
                                    new Type[] { typeof(int), typeof(int) });
        //  2.调用该方法
        //  注意：如果是静态方法，Invoke()中的第一个参数要传入null
        string str = "1234567890";
        object result = subStr.Invoke(str, new object[] { 2, 4 });
        Console.WriteLine(result);
```

##### 其他获取：

```csharp
        //其他获得：
        //  得枚举：GetEnumName
        //  得事件：GetEvent
        //  得属性：GetProperty
        //  得接口：GetInterface  
```


### 特性


## 异步编程——async 和 await

## 游戏常用查找(寻路)
