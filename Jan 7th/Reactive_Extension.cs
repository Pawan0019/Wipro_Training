using System.Reactive.Linq;

class Program
{
    static void Main()
    {
        // Create an obersable that emits numbers every second
        var observable = Observable.Interval(TimeSpan.FromSeconds(1));

        // Subscribe to the observable
        var subscription = observable.Subscribe(
            value => Console.WriteLine("Received:" + value),
            error => Console.WriteLine("Error:" + error.Message),
            () => Console.WriteLine("Completed")

        );

        Console.WriteLine("Press Enter to stop...");
        Console.ReadLine();

        //Stop listening
        subscription.Dispose();
    }
}