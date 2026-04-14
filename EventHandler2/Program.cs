using System;

public class Program
{
    public static void Main(string[] args)
    {
        Stock stock = new Stock("tes");
        stock.PriceChanged += Stock_PriceChanged;

        stock.Price = 27.10M;
        stock.Price = 31.59M;
        stock.Price = 43.35M;
        stock.Price = 53.35M;

        // stock.PriceChanged += Stock_PriceChanged;

        void Stock_PriceChanged(object? sender, PriceChangedEventArgs e)
        {
            if (e.LastPrice > 0 && (e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
            {
                // Console.WriteLine("Alert, 10% stock price Increase");
                Console.WriteLine(e.NewPrice);
            }
        }
    }
}

public class PriceChangedEventArgs : EventArgs
{
    public readonly decimal LastPrice;
    public readonly decimal NewPrice;

    public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
    {
        this.LastPrice = lastPrice;
        this.NewPrice = newPrice;
    }
}

public class Stock
{
    string mySymbol;
    decimal myPrice;

    public Stock(string symbol)
    {
        this.mySymbol = symbol;
    }

    public event EventHandler<PriceChangedEventArgs>? PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get => myPrice;
        set
        {
            if (myPrice == value)
                return;
            decimal oldPrice = myPrice;
            myPrice = value;
            OnPriceChanged(new PriceChangedEventArgs(oldPrice, myPrice));
        }
    }
}
