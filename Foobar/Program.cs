using System;

class Program
{
    static void Main(string[] args)
    {
        Foobar(105);
    }

    static void Foobar(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("foobarjazz");
                }
                else
                {
                    Console.WriteLine("foobar");
                }
            }
            else if (i % 3 == 0)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("foojazz");
                }
                else
                {
                    Console.WriteLine("foo");
                }
            }
            else if (i % 5 == 0)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("barjazz");
                }
                else
                {
                    Console.WriteLine("bar");
                }
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}