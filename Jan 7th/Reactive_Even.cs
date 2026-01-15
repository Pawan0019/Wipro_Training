using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;

//1. Observable that emits a value every 2 seconds and prints "Tick" with the value
class Program
{
    static void Main()
    {
        var observable = Observable
            .Interval(TimeSpan.FromSeconds(2))
            .Subscribe(value =>
            {
                Console.WriteLine($"Tick {value}");
            });

        Console.ReadLine(); // Keep app running
        observable.Dispose();
    }
}


//2. Transform a stream of numbers by multiplying each value by 5
class Program
{
    static void Main()
    {
        var numbers = Observable.Range(1, 5);

        numbers
            .Select(x => x * 5)
            .Subscribe(result =>
            {
                Console.WriteLine(result);
            });

        Console.ReadLine();
    }
}


//3. Count how many values are emitted from an observable (1 to 20)
class Program
{
    static void Main()
    {
        Observable
            .Range(1, 20)
            .Count()
            .Subscribe(count =>
            {
                Console.WriteLine($"Total values emitted: {count}");
            });

        Console.ReadLine();
    }
}


//4. Observable that emits names and prints only names starting with 'A'
class Program
{
    static void Main()
    {
        var names = new List<string>
        {
            "Amit", "Rahul", "Ananya", "Sneha", "Arjun", "Neha"
        };

        names
            .ToObservable()
            .Where(name => name.StartsWith("A"))
            .Subscribe(name =>
            {
                Console.WriteLine(name);
            });

        Console.ReadLine();
    }
}

