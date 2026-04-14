
using System.Reflection.Metadata;
using MyApp.Delegates;


class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        void WriteProgressToConsole(int percentComplete) => Console.WriteLine($"Progress: {percentComplete}%");

        void WriteProgressToFile(int percentComplete) => File.WriteAllText("progress.txt", $"Progress: {percentComplete}%");

        ProgressDelegate reporter = WriteProgressToConsole;
        reporter += WriteProgressToFile;


        Test.HardWork(reporter);
        // Test test = new Test();
        // Test.SomeDelegate del1 = test.SomeMethod;
        // del1 += test.SomeMethod2;
        // del1.Invoke();


        // Test test = new Test();
        // Transformer transformer = test.Square;
        // Console.WriteLine(transformer(10));
    }
}

public delegate void ProgressDelegate(int progress);
class Test
{
    public static void HardWork(ProgressDelegate progressDelegate)
    {
        for (int i = 0; i <= 10; i++)
        {
            progressDelegate(i * 10);
            System.Threading.Thread.Sleep(1000);
        }
    }
}

//    public delegate void SomeDelegate();
//    public void SomeMethod() => Console.WriteLine("Method 1");
//     public void SomeMethod2() => Console.WriteLine("Method 2");    
// }

// class Test
// {
//     // public static int Square(int x) => x * x;
//     // public int Square(int x) => x * x;
// }

// delegate int Transformer(int x);



=======
        ValueChanger valueChanger = new ValueChanger();
        ChangeValue changeValueDelegate = valueChanger.Change;

        int value = changeValueDelegate(5);
        Console.WriteLine("Returned value: " + value);
    }
}

>>>>>>> 7cb7197c24dbd0329041998ef65057cd8e7ea1ed


