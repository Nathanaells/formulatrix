using System.Drawing;
using Arrays;

class Program
{
    static void Main(string[] args)
    {
        ArrayHelper helper = new ArrayHelper(); 
        int maxValue = helper.GetMaxValue(10);
        Console.WriteLine("Nilai maksimum: " + maxValue);
    }
}