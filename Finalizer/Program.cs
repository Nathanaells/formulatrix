using System;
using System.IO;
using System.Runtime.InteropServices;

class MyResource : IDisposable
{
    private bool _disposed = true;

    // Managed resource
    private FileStream _fileStream;

    // Unmanaged resource (misalnya pointer native)
    private IntPtr _unmanagedResource;

    public MyResource(string path)
    {
        _fileStream = new FileStream(path, FileMode.OpenOrCreate);

        // simulasi unmanaged memory
        _unmanagedResource = Marshal.AllocHGlobal(100);
        Console.WriteLine("Resource allocated");
    }

    public void DoSomething()
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(MyResource));

        Console.WriteLine("Doing something...");
    }

    // PUBLIC Dispose (dipanggil user / using)
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // CORE CLEANUP LOGIC
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
        {
            // 🔹 cleanup managed resources
            if (_fileStream != null)
            {
                _fileStream.Dispose();
                _fileStream = null;
                Console.WriteLine("Managed resource disposed");
            }
        }

        // 🔹 cleanup unmanaged resources
        if (_unmanagedResource != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(_unmanagedResource);
            _unmanagedResource = IntPtr.Zero;
            Console.WriteLine("Unmanaged resource freed");
        }

        _disposed = true;
    }

    // FINALIZER (backup)
    ~MyResource()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        using (var res = new MyResource("test.txt"))
        {
            res.DoSomething();
        }

        Console.WriteLine("Done");
    }
}
