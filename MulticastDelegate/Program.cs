class Program
{
    public static void Main(string[] args)
    {
        Test test = new Test();

        Test.SomeDelegate d = test.SomeMethod;
        d += test.SomeMethod2;
        d.Invoke();
    }
}

class Test
{
    public delegate void SomeDelegate();

    public void SomeMethod() => Console.WriteLine("Method 1");

    public void SomeMethod2() => Console.WriteLine("Method 2");
}
