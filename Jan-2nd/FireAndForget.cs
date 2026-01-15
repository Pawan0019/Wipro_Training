using System;
using System.Threading.Tasks;

public class FireAndForget
{
    static async Task PrintMessageAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Hello after delay");
    }
    static async Task Main()
    {
        Console.WriteLine("Main started");
        
        PrintMessageAsync(); // not awaited
        
        Console.WriteLine("Main finished");
    }
}