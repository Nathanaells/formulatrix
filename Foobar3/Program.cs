class Program
{
    public static void Main(string[] args)
    {
        Foobar(105);
    }

    public static void Foobar(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            string result = "";

            if (i % 3 == 0)
            {
                result += "foo";
            }

            if (i % 4 == 0)
            {
                result += "baz";
            }

            if (i % 5 == 0)
            {
                result += "bar";
            }

            if (i % 7 == 0)
            {
                result += "jazz";
            }

            if (i % 9 == 0)
            {
                result += "huzz";
            }

            if (result == "")
            {
                Console.WriteLine(i);
                continue;
            }

            Console.WriteLine(result);
        }
    }
}
