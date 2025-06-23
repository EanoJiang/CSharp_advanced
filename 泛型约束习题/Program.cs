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

class Program
{
    static void Main(string[] args)
    {

    }
}
