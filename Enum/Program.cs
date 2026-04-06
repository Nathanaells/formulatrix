
class Program
{
    static void Main(string[] args)
    {
       BorderSide leftRight = BorderSide.Left | BorderSide.Right;   

        if((leftRight & BorderSide.Left) != 0)
            Console.WriteLine("Border kiri dipilih");

            string formatted = leftRight.ToString();

            BorderSide s = BorderSide.Left;
            s |= BorderSide.Right; // Menambahkan BorderSide.Right ke s 

            Console.WriteLine(s == leftRight); // Output: True

            s ^= BorderSide.Right;
            Console.WriteLine(s);
        
    }
}




[Flags]
public enum BorderSide : byte {
    Left = 1, 
    Right = 2, 
    Top = 4, 
    Bottom = 8
    };
