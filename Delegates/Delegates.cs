namespace MyApp.Delegates;


public delegate int ChangeValue(int value);


public class ValueChanger
{
    public int Change(int value)
    {
        value++;
        Console.WriteLine("Value changed to: " + value);
        return value;
    }
}