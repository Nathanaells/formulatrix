using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder("Hello, World!");
        var weak1 = new WeakReference(sb);

        Console.WriteLine(weak1.Target); // True

        var weak2 = GetWeakRef();
        GC.Collect();
        Console.WriteLine(weak2.Target); // False

        var sb2 = (StringBuilder)weak2.Target;

        if (sb2 != null)
            Console.WriteLine(sb2.ToString());
        else
            Console.WriteLine("Object has been collected");

        WeakReference GetWeakRef() => new WeakReference(new StringBuilder("weak"));
    }
}
