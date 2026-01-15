// ## Exercise - https://drive.google.com/file/d/1Kkgyjz96xLI0MgsskCfbTpHYZfmjqtdS/view?usp=sharing

using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Assignment
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Async Await Demo ===\n");

        // 1. Wait 2 seconds and print message
        await PrintAfterDelayAsync();

        // 2. Async method returning integer
        int result = await GetNumberAfterDelayAsync();
        Console.WriteLine($"Returned Value: {result}\n");

        // 3. Call async method twice sequentially
        Console.WriteLine("Sequential Execution:");
        Stopwatch sw1 = Stopwatch.StartNew();
        await DelayOperationAsync();
        await DelayOperationAsync();
        sw1.Stop();
        Console.WriteLine($"Total Time (Sequential): {sw1.ElapsedMilliseconds} ms\n");

        // 4. Call async method twice in parallel
        Console.WriteLine("Parallel Execution:");
        Stopwatch sw2 = Stopwatch.StartNew();
        await Task.WhenAll(
            DelayOperationAsync(),
            DelayOperationAsync()
        );
        sw2.Stop();
        Console.WriteLine($"Total Time (Parallel): {sw2.ElapsedMilliseconds} ms\n");

        // 5. Exception handling in async method
        Console.WriteLine("Exception Handling:");
        try
        {
            await ThrowExceptionAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}\n");
        }

        // 6. Independent async methods
        Console.WriteLine("Independent Async Methods:");
        await Task.WhenAll(
            FirstIndependentAsync(),
            SecondIndependentAsync()
        );

        Console.WriteLine("\n=== Program Completed ===");
    }

    // 1. Async method that waits 2 seconds
    static async Task PrintAfterDelayAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Task completed\n");
    }

    // 2. Async method returning an integer
    static async Task<int> GetNumberAfterDelayAsync()
    {
        await Task.Delay(1500);
        return 42;
    }

    // 3. & 4. Used for sequential & parallel execution
    static async Task DelayOperationAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Delay operation finished");
    }

    // 5. Async method that throws exception
    static async Task ThrowExceptionAsync()
    {
        await Task.Delay(1000);
        throw new InvalidOperationException("Something went wrong!");
    }

    // 6. Independent async methods
    static async Task FirstIndependentAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("First independent task completed");
    }

    static async Task SecondIndependentAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Second independent task completed");
    }
}