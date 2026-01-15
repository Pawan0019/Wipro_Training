using System;
using System.Collections.Generic;

class QueueExercise
{
    static Queue<int> queue = new Queue<int>();

    static void Main()
    {
        Console.WriteLine("===== QUEUE EXERCISES =====");

        EnqueueAndPrint();
        DequeueTwo();
        PeekFront();
        CheckEmptyBeforeDequeue();
        PrinterQueue();

        Console.ReadLine();
    }

    // 1. Enqueue 5 numbers and print
    static void EnqueueAndPrint()
    {
        queue.Clear();
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i * 100);
        }

        PrintQueue();
    }

    // 2. Dequeue two elements
    static void DequeueTwo()
    {
        if (queue.Count >= 2)
        {
            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        }
        else
        {
            Console.WriteLine("Not enough elements to dequeue.");
        }

        PrintQueue();
    }

    // 3. Peek front element
    static void PeekFront()
    {
        if (queue.Count > 0)
            Console.WriteLine("Front Element: " + queue.Peek());
        else
            Console.WriteLine("Queue is empty.");
    }

    // 4. Check empty before dequeue
    static void CheckEmptyBeforeDequeue()
    {
        if (queue.Count == 0)
            Console.WriteLine("Queue is empty. Cannot dequeue.");
        else
            Console.WriteLine("Dequeued Element: " + queue.Dequeue());
    }

    // 5. Printer queue simulation
    static void PrinterQueue()
    {
        Queue<string> printerQueue = new Queue<string>();

        printerQueue.Enqueue("Doc1.pdf");
        printerQueue.Enqueue("Doc2.docx");
        printerQueue.Enqueue("Doc3.xlsx");

        Console.WriteLine("Printing Documents:");
        while (printerQueue.Count > 0)
        {
            Console.WriteLine("Printing: " + printerQueue.Dequeue());
        }
    }

    static void PrintQueue()
    {
        Console.WriteLine("Queue Elements:");
        foreach (int item in queue)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}