using System;

public class ThreadPractice
{
    static void Main()
    {
        Thread t = new Thread(Work);
        t.Start();

        t.Join(); // Main thread waits here
        Console.WriteLine("Main thread finished");
        
    }

    static void Work()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Worker thread finished");
    }

    // Single Thread
    static void printNumbers()
    {
       for (int i = 1;i <=5; i++)
       {
           Console.WriteLine(i);
           Thread.Sleep(1000);
       }
    } 
}