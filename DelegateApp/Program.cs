
using MyApp.Delegates;


class Program
{
    static void Main(string[] args)
    {
        int[] values = [1, 2, 3 ];
        ValueChanger changer = new ValueChanger();

        changer.Transform(values, changer.Square);
        foreach(int i in values)
        {
            Console.WriteLine("Squared value: " + i);
        }
        
    }
}



