using System.Diagnostics;

namespace Inheritance
{
    public class Asset
    {
        public string Name;

        public static void Display(Asset asset)
        {
            Console.WriteLine("Asset Name: " + asset.Name);
        }
    }


    public class Stock : Asset
    {
        public string Ticker;

    
        public static void Display(Asset asset)
        {
            Stock stock = (Stock)asset;
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Ticker: " + stock.Ticker);
        }
    }

    public class House : Asset
    {
        public string Address;
    }
}