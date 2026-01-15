using System;
using System.Threading;

class Synchronous
{
    static void Main()
    {
        Console.WriteLine("Task 1 started");
        Thread.Sleep(3000); // Simulate long task
        Console.WriteLine("Task 1 finished");
        Console.WriteLine("Task 2 started");
        Console.WriteLine("Task 2 finished");
    }
}