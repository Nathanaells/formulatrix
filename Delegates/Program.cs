
using System.Reflection.Metadata;
using MyApp.Delegates;


class Program
{
    static void Main(string[] args)
    {
        ValueChanger valueChanger = new ValueChanger();
        ChangeValue changeValueDelegate = valueChanger.Change;

        int value = changeValueDelegate(5);
        Console.WriteLine("Returned value: " + value);
    }
}



