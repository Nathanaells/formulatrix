namespace MyApp.Products;


class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    private static int _lastID = 0;
    private int ProductId { get; set; }
    public Product(string name, decimal price)
    {
        _lastID++;
        ProductId = _lastID;
        Name = name;
        Price = price;
    }

    public int GetProductId()
    {
        return ProductId;
    }
}
