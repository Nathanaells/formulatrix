using System.Diagnostics;

class Program
{
    static void Main()
    {
        LogDebug();
    }

    [Conditional("DEBUG")]
    static void LogDebug()
    {
        Debug.WriteLine("This is a debug message.");
        Console.WriteLine("Debug mode aktif");
    }
}
