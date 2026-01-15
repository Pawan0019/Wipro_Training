using System;
using System.Threading.Tasks;

class Asynchronous
{
    static async Task Main()
    {
        Console.WriteLine("Task 1 started");
        await Task.Delay(3000); // Non-blocking delay
        Console.WriteLine("Task 1 finished");
        Console.WriteLine("Task 2 started");
        Console.WriteLine("Task 2 finished");
    }
}