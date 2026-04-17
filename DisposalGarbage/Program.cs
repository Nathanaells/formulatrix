using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        string procName = Process.GetCurrentProcess().ProcessName;
        using PerformanceCounter pc = new PerformanceCounter("Process", "Private Bytes", procName);
        Console.WriteLine(pc.NextValue());
    }
}

class Foo
{
    public int _suspendCount;

    public IDisposable SuspendEvents()
    {
        _suspendCount++;
        return new SuspendToken(this);
    }

    public void ResumeEvents() => _suspendCount--;
}

class SuspendToken : IDisposable
{
    Foo _foo;

    public SuspendToken(Foo foo)
    {
        _foo = foo;
    }

    public void Dispose()
    {
        if (_foo != null)
            _foo._suspendCount--;
        _foo = null;
    }
}
