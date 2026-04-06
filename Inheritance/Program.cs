using Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock { Name = "MSFT", Ticker = "MSFT" };
        House house = new House { Name = "My House", Address = "123 Main St" };

        Stock.Display(stock);

        Asset a = stock;
        Asset b = house;

        Asset.Display(a);
        Asset.Display(b);
    }
}