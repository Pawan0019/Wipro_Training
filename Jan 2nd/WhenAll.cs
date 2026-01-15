using System;
using System.Threading.Tasks;

public class HelloWorld
{
    static async Task PrintMessageAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Hello after delay");
    }
    static async Task Main()
    {
        Console.WriteLine("Main started");

        Task t1 PrintMessageAsync();
        Task t2 PrintMessageAsync();

        await Task.WhenAll(t1, t2);

        Console.WriteLine("Main finished");
    }
}