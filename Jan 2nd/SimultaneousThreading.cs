using System;
using System.Threading.Tasks;

class SimultaneousThreading
{
    static async Task PrintMessageAsync()
    {
        await Task.Delay(2000);
        Console.WriteLine("Hello after delay");
    }
    static async Task Main()
    {
        Console.WriteLine("Main started");

        await PrintMessageAsync();
        await PrintMessageAsync();

        Console.WriteLine("Main finished");
    }
}