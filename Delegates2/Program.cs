class Program
{

    public static int Square(int x) => x * x;
    public static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 4, 5];
        Test.Transformer<int>(array, Square);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}


public delegate TypeA Transformer<TypeA, TypeB>(TypeB arg);
//return data TypeA


public class Test
{
    public static void Transformer<T>(T[] array, Transformer<T, T> t)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = t(array[i]);
        }
    }
}