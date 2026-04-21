using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Task task = Task.Run(() =>
        // {
        //     throw new NullReferenceException("Oops!");
        // });

        // try
        // {
        //     task.Wait();
        // }
        // catch (AggregateException aex)
        // {
        //     if (task.IsFaulted)
        //     {
        //         Console.WriteLine("Task is faulted as expected.");
        //     }

        //     if (
        //         aex.InnerException is NullReferenceException
        //         && aex.InnerException.Message == "Oops!"
        //     )
        //     {
        //         Console.WriteLine("NullReferenceException caught!");
        //     }
        //     else
        //     {
        //         Console.WriteLine(
        //             $"Unexpected exception: {aex.InnerException}----------------------------------------------------------"
        //         );
        //         throw; // Re-throw other unexpected exceptions
        //     }
        // }

        Task<int> GetAnswerToLife()
        {
            var tcs = new TaskCompletionSource<int>();
            // Create a timer that will fire once after 5 seconds
            var timer = new System.Timers.Timer(5000) { AutoReset = false };
            timer.Elapsed += (sender, e) =>
            {
                timer.Dispose(); // Clean up the timer
                var awaiter = Task.FromResult(42).GetAwaiter(); // Create an awaiter for the result
                tcs.SetResult(42); // Manually complete the task with result 42
            };
            timer.Start();
            return tcs.Task; // Return the controllable task
        }

        // Attach a continuation to print the result without blocking a thread
        GetAnswerToLife()
            .GetAwaiter()
            .OnCompleted(() => Console.WriteLine(GetAnswerToLife().GetAwaiter().GetResult()));
    }

    public static void MyMethod(object state)
    {
        Thread current = Thread.CurrentThread;
        Console.WriteLine(
            $"Background: {current.IsBackground}, Thread Pool: {current.IsThreadPoolThread}, Thread ID: {current.ManagedThreadId}"
        );
    }

    public static void SomeMethod()
    {
        object lockObject = new object();
        // TryEnter attempts to acquire the lock and returns immediately if unsuccessful
        if (Monitor.TryEnter(lockObject))
        {
            try
            {
                Console.WriteLine("Inside critical section.");
                Console.WriteLine("Starting Thread 2...");
                Thread.Sleep(1000);
                throw new Exception("Simulated exception to test lock release.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception caught: {ex.Message}");
            }
            finally
            {
                Monitor.Exit(lockObject); // Ensures lock is released even if exception occurs
            }
        }
        else
        {
            Console.WriteLine("Failed to enter critical section.");
        }
    }

    static void Thread2Method()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread 2: {i}");
            Thread.Sleep(1500);
        }
    }
}
