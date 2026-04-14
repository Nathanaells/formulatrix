using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        // string s = true.ToString();
        // bool b = bool.Parse(s);

        // bool failure = int.TryParse("qwerty", out int tes);
        // bool success = int.TryParse("123", out int tes2);

        // // Console.WriteLine(tes2);

        // NumberFormatInfo f = new();
        // f.CurrencySymbol = "$";
        // Console.WriteLine(3.ToString("C", f));

        // CultureInfo idCulture = CultureInfo.GetCultureInfo("id-ID");
        // Console.WriteLine(3.ToString("C", idCulture));

        // DateTime dt = new(2000, 1, 2);

        // CultureInfo invariantCulture = CultureInfo.InvariantCulture;

        // Console.WriteLine(dt.ToString(invariantCulture));
        // Console.WriteLine(dt.ToString("d", invariantCulture));

        // NumberFormatInfo customFormat = (NumberFormatInfo)
        //     CultureInfo.CurrentCulture.NumberFormat.Clone();
        // customFormat.NumberGroupSeparator = " "; // Change thousands separator to a space
        // Console.WriteLine(12345.6789.ToString("N3", customFormat)); // 12 345.679

        // Console.WriteLine("Credit={0:C}", 500); // Credit=$500.00 (uses current culture's currency)
        // object tes = "123";
        // // You can specify a format provider for composite formatting
        // string s = string.Format(CultureInfo.InvariantCulture, "{0}", tes);

        // Console.WriteLine(s);

        // string hex = 45.ToString("x");
        // // Console.WriteLine(hex);

        // int i = Convert.ToInt32("1E", 16);
        // Console.WriteLine(i);

        // Half h = (Half)134.5444f;

        // Console.WriteLine(h);

        // var c1 = new Complex(2, 0);
        // Console.WriteLine(c1);

        RandomNumberGenerator a = RandomNumberGenerator.Create();

        byte[] data = new byte[5];

        a.GetBytes(data);




        int randomValues = BitConverter.ToInt32(data, 0);

        Console.WriteLine(randomValues);
    }
}
