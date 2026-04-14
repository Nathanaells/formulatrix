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
                else if (i % 9 == 0)
                {
                    Console.WriteLine("foobarhuzz");
                }
                else
                {
                    Console.WriteLine("foobar");
                }
            }
            else if (i % 3 == 0)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("foohuzz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("foojazz");
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("foobaz");
                }
                else
                {
                    Console.WriteLine("foo");
                }
            }
            else if (i % 5 == 0)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine("barhuzz");
                }
                if (i % 7 == 0)
                {
                    Console.WriteLine("barjazz");
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("barbaz");
                }
                else
                {
                    Console.WriteLine("bar");
                }
            }
            else if (i % 4 == 0)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("bazjazz");
                }
                else
                {
                    Console.WriteLine("baz");
                }
            }
            else if (i % 7 == 0)
            {
                Console.WriteLine("jaz");
            }
            else if (i % 9 == 0)
            {
                Console.WriteLine("huzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
