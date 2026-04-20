public class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;

        FoobarGenerator generator = new FoobarGenerator(new Dictionary<int, string>());

        Console.WriteLine("Masukan Input Angka untuk di cek:");

        int input1;

        while (!int.TryParse(Console.ReadLine(), out input1))
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka.");
        }

        while (isRunning)
        {
            Console.WriteLine("Masukan Rules:");
            Console.WriteLine("Rules Dimasukan dengan format angka");
            int input2;
            if (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                continue;
            }

            Console.WriteLine("Output Rules:");

            string? output = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine("Output tidak valid. Harap masukkan string.");
                continue;
            }

            generator.AddRule(input2, output);
            Console.WriteLine("Apakah ingin menambahkan rules lagi? (y/n)");

            string? choice = Console.ReadLine();

            if (!string.Equals(choice, "y", StringComparison.OrdinalIgnoreCase))
            {
                isRunning = false;
            }
        }

        string[] foobarResults = FoobarGenerator.PrintFoobar(generator.Rules, input1);

        Console.WriteLine("Hasil Foobar:");
        foreach (string result in foobarResults)
        {
            Console.WriteLine(result);
        }
    }
}
