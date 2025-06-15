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
