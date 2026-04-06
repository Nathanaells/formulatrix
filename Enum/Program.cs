
class Program
{
    static void Main(string[] args)
    {
        int i = (int)BorderSide.Left;
        Console.WriteLine("Nilai BorderSide.Left: " + i);

    }
}




[Flags]
public enum BorderSide : byte {
    Left = 1, 
    Right = 2, 
    Top = 3, 
    Bottom = 4
    };

public enum BorderSide2
{
    Left = BorderSide.Left,
    Right = BorderSide.Right,        
    Top = BorderSide.Top,
    Bottom = BorderSide.Bottom
}