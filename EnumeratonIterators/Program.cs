class Program
{
    static IEnumerable<int> Fibonacci(int count)
    {
        for (int i = 0, pre
        vFib = 1, curFib = 1; i < count; i++)
        {
            yield return prevFib; // ini yang di return ke EvenNumbersOnly
            int newFib = prevFib + curFib;
            prevFib = curFib;
            curFib = newFib;
        }
    }

    static IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence)
    // EvenNumbersOnly nerima method IENUMERABLE
    {
        foreach (int x in sequence)
        {
            // Console.WriteLine(x + "<<<<<<<<<<<<<<<<<< ini ANGKA FIBONACCI");

            if ((x % 2) == 0)
            {
                yield return x;
            }
        }
    }

    static void Main(string[] args)
    {
        foreach (int a in EvenNumbersOnly(Fibonacci(10)))
        {
            Console.WriteLine(a + "INI YANG GENAP");
        }
    }
}
