using MyApp.Products;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        List<Product> products = new List<Product>();

        while (!exit)
        {
            Console.WriteLine("Selamat Datang di Toko Nathan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Lihat Produk");
            Console.WriteLine("3. Keluar");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Masukkan nama produk:");
                    string productName = Console.ReadLine();

                    Console.WriteLine("Masukkan harga produk:");
                    decimal productPrice = decimal.Parse(Console.ReadLine());

                    Product newProduct = new Product(productName, productPrice);

                    products.Add(newProduct);

                    Console.WriteLine("Produk berhasil ditambahkan!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Daftar Produk:");

                    foreach (var product in products)
                    {
                        Console.WriteLine(
                            $"ID: {product.GetProductId()}, Nama: {product.Name}, Harga: {product.Price}"
                        );
                    }
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    break;
                case 3:
                    exit = true;
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi ini. Sampai jumpa!");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
        }
    }
}
