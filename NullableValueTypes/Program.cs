class Program
{
    static void Main(string[] args)
    {
        System.Text.StringBuilder sb = null;
        int? length = sb?.ToString().Length;

        Console.WriteLine(length);
    }
}
