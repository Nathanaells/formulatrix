class Program
{
    public static void Main(string[] args)
    {
        TimeSpan tes = TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30);
        TimeSpan tes2 = TimeSpan.FromDays(10) - TimeSpan.FromDays(1);
        bool isTrue = TimeSpan.TryParse("04:50", out TimeSpan duration);

        Console.WriteLine(duration);
        // Console.WriteLine(tes2.ToString());
    }
}
