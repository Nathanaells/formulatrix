class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(Display(Nut.Bottom));
        // object result = GetBoxed(Nut.Left);

        // Console.WriteLine(result.GetType());

        // object tes = Enum.ToObject(typeof(Nut), 3);

        // Console.WriteLine(tes);

        double x = double.NaN;
        double y = double.NaN;
        Console.WriteLine(x == x); // False (mathematically, NaN is never equal to anything, even itself)
        Console.WriteLine(x.Equals(y));
    }

    static decimal Display(Enum value)
    {
        // Console.WriteLine(value.GetType().Name);
        // return (decimal)(object)value;
        return Convert.ToDecimal(value);
    }

    static object GetBoxed(Enum value)
    {
        Type intType = Enum.GetUnderlyingType(value.GetType());
        return Convert.ChangeType(value, intType);
    }

    [Flags]
    public enum Nut
    {
        Left = 1,
        Right = 2,
    }

    enum Size
    {
        Small,
        Medium,
        Large,
    }
}
