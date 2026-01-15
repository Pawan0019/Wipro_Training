using System;
using System.Threading.Tasks;

class Exception
{
    static async Task Task1()
    {
        await Task.Delay(1000);
        throw new Exception("Task! failed");
    }

    static async Task Task2()
    {
        await Task.Delay(1000);
        throw new Exception("Task2 failed");
    }
    
    static async Task Main()
    {
        try
        {
            await Task.WhenAll(Task1(), Task2());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}