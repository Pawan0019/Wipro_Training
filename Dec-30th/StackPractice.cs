using System;
public class StackPractice
{
    public static void Main()
    {
        Stack<int> history = new Stack<int>();

        history.Push(10);
        history.Push(20);
        history.Push(30);
        history.Push(40);

        int remove = history.Pop();
        int top = history.Peek();
        int count = history.Count();

        Console.WriteLine(remove);
        Console.WriteLine(top);
        Console.WriteLine(count);
        foreach (int item in history)
        {
           Console.WriteLine(item);
        }
    }
}