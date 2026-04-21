class Program
{
    static async Task Main(string[] args)
    {
        async Task<int> Delay1()
        {
            await Task.Delay(4000);
            Console.WriteLine("Delay 1 completed!");
            return 1;
        }
        async Task<int> Delay2()
        {
            await Task.Delay(2000);
            Console.WriteLine("Delay 2 completed!");
            return 2;
        }
        async Task<int> Delay3()
        {
            await Task.Delay(3000);
            Console.WriteLine("Delay 3 completed!");
            return 3;
        }

        // Example usage:
        int[] completedTask = await Task.WhenAll(Delay1(), Delay2(), Delay3());
        Console.WriteLine(completedTask[0] + completedTask[1] + completedTask[2]);
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
