using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        // string nullString = "";
        // Console.WriteLine(nullString == null);
        // Console.WriteLine(nullString == "");
        // Console.WriteLine(string.IsNullOrEmpty(nullString));

        // Console.WriteLine(string.Equals("FOO", "foo"));

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < 50; i++)
        {
            sb.Append(i);
        }

        sb.Insert(0, "tes");

        Console.WriteLine(sb.ToString());
    }
}
