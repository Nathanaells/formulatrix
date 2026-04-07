class Program
{
    static void Main(string[] args)
    {
    Func<int, string> testFunc = (x) =>
    {
        if(x % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }   
    };   

    Console.WriteLine(testFunc(5));  
    }
}

