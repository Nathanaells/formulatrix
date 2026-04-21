class Program
{
    static async Task Main(string[] args)
    {
        // Attach a continuation to print the result without blocking a thread
        var answer = await GetAnswerToLife().ContinueWith(t => t.GetAwaiter().GetResult());
        Console.WriteLine(answer);
    }

    static Task<int> GetAnswerToLife()
    {
        var tcs = new TaskCompletionSource<int>();
        // Create a timer that will fire once after 5 seconds
        var timer = new System.Timers.Timer(5000) { AutoReset = false };
        timer.Elapsed += (sender, e) =>
        {
            timer.Dispose(); // Clean up the timer
            tcs.SetResult(42); // Manually complete the task with result 42
        };
        timer.Start();
        return tcs.Task; // Return the controllable task
    }

    static async Task<int> GetPrimesCountAsync(int start, int count)
    {
        return await Task.Run(() =>
            ParallelEnumerable
                .Range(start, count)
                .Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0))
        );
    }

    static async Task Foo(IProgress<int> onProgressPercentChanged)
    {
        await Task.Run(() =>
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 100 == 0)
                    onProgressPercentChanged.Report(i / 10);
                // Simulate compute-bound work
                Thread.Sleep(10);
            }
        });
    }

    static async Task DisplayPrimeCountAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(
                await GetPrimesCountAsync(i * 1000000 + 1, 1000000)
                    + $" primes found in iteration {i}"
            );
        }

        Console.WriteLine("Done counting primes!");
    }
}
