using System;

class Program
{
    public static void Main(string[] args)
    {
        Util util = new Util();
        string[] values = ["1", "2", "3"];

        Util.Transform(values, util.Square);

        foreach (string v in values)
            Console.WriteLine(v);
    }
}

public delegate TResult Transformer<TArg, TResult>(TArg arg);

public class Util
{
    public static void Transform<T>(T[] values, Transformer<T, T> t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t(values[i]);
    }

    public string Square(string x)
    {
        int value = int.Parse(x);
        return (value * value).ToString();
    }
}