public class Program
{
    public static void Main(string[] args)
    {
        bool isRunning = true;
        FoobarGenerator generator = new FoobarGenerator(new Dictionary<int, string>());

        Console.WriteLine("Masukan Input Angka untuk di cek:");
        int input1 = int.Parse(Console.ReadLine());

        while (isRunning)
        {
            Console.WriteLine("Masukan Rules:");
            Console.WriteLine("1. Bagi 3 = foo");
            Console.WriteLine("2. Bagi 4 = baz");
            Console.WriteLine("3. Bagi 5 = bar");
            Console.WriteLine("4. Bagi 7 = jazz");
            Console.WriteLine("5. Bagi 9 = huzz");
            Console.WriteLine("6. Hapus Rules");
            Console.WriteLine("7. Cetak Foobar");
            Console.WriteLine("8. Exit");

            int input2 = int.Parse(Console.ReadLine());

            switch (input2)
            {
                case 1:
                    if (generator.AddRule(3, "foo"))
                    {
                        Console.WriteLine("Rules bagi 3 = foo telah ditambahkan.");
                        Console.WriteLine(
                            "--------------------------------------------------------------"
                        );
                    }
                    break;
                case 2:
                    if (generator.AddRule(4, "baz"))
                    {
                        Console.WriteLine("Rules bagi 4 = baz telah ditambahkan.");
                        Console.WriteLine(
                            "--------------------------------------------------------------"
                        );
                    }
                    break;
                case 3:
                    if (generator.AddRule(5, "bar"))
                    {
                        Console.WriteLine("Rules bagi 5 = bar telah ditambahkan.");
                        Console.WriteLine(
                            "--------------------------------------------------------------"
                        );
                    }
                    break;
                case 4:
                    if (generator.AddRule(7, "jazz"))
                    {
                        Console.WriteLine("Rules bagi 7 = jazz telah ditambahkan.");
                        Console.WriteLine(
                            "--------------------------------------------------------------"
                        );
                    }
                    break;
                case 5:
                    if (generator.AddRule(9, "huzz"))
                    {
                        Console.WriteLine("Rules bagi 9 = huzz telah ditambahkan.");
                        Console.WriteLine(
                            "--------------------------------------------------------------"
                        );
                    }
                    break;

                case 6:
                    Console.WriteLine("Pilih Rules yang ingin dihapus:");
                    Console.WriteLine("1. Bagi 3 = foo");
                    Console.WriteLine("2. Bagi 4 = baz");
                    Console.WriteLine("3. Bagi 5 = bar");
                    Console.WriteLine("4. Bagi 7 = jazz");
                    Console.WriteLine("5. Bagi 9 = huzz");
                    Console.WriteLine("6. Kembali");
                    int input3 = int.Parse(Console.ReadLine());

                    switch (input3)
                    {
                        case 1:
                            if (generator.RemoveRule(3))
                            {
                                Console.WriteLine("Rules bagi 3 = foo telah dihapus.");
                                Console.WriteLine(
                                    "--------------------------------------------------------------"
                                );
                            }
                            break;
                        case 2:
                            if (generator.RemoveRule(4))
                            {
                                Console.WriteLine("Rules bagi 4 = baz telah dihapus.");
                                Console.WriteLine(
                                    "--------------------------------------------------------------"
                                );
                            }
                            break;
                        case 3:
                            if (generator.RemoveRule(5))
                            {
                                Console.WriteLine("Rules bagi 5 = bar telah dihapus.");
                                Console.WriteLine(
                                    "--------------------------------------------------------------"
                                );
                            }
                            break;
                        case 4:
                            if (generator.RemoveRule(7))
                            {
                                Console.WriteLine("Rules bagi 7 = jazz telah dihapus.");
                                Console.WriteLine(
                                    "--------------------------------------------------------------"
                                );
                            }
                            break;
                        case 5:
                            if (generator.RemoveRule(9))
                            {
                                Console.WriteLine("Rules bagi 9 = huzz telah dihapus.");
                                Console.WriteLine(
                                    "--------------------------------------------------------------"
                                );
                            }
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                    break;

                case 7:
                    FoobarGenerator.PrintFoobar(generator.Rules, input1);
                    isRunning = false;
                    break;
                case 8:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}
