using System;
using System.Collections.Generic;

class StackExercise
{
    static Stack<int> stack = new Stack<int>();

    static void Main()
    {
        Console.WriteLine("===== STACK EXERCISES =====");

        PushAndPrint();
        PopAndDisplay();
        PeekElement();
        CheckEmptyBeforePop();
        ReverseString("HelloStack");

        Console.ReadLine();
    }

    // 1. Push 5 numbers and print
    static void PushAndPrint()
    {
        stack.Clear();
        for (int i = 1; i <= 5; i++)
        {
            stack.Push(i * 10);
        }

        Console.WriteLine("Stack Elements:");
        PrintStack();
    }

    // 2. Pop top element and display remaining
    static void PopAndDisplay()
    {
        if (stack.Count > 0)
            Console.WriteLine("Popped Element: " + stack.Pop());
        else
            Console.WriteLine("Stack is empty.");

        PrintStack();
    }

    // 3. Peek top element
    static void PeekElement()
    {
        if (stack.Count > 0)
            Console.WriteLine("Top Element: " + stack.Peek());
        else
            Console.WriteLine("Stack is empty.");
    }

    // 4. Check empty before pop
    static void CheckEmptyBeforePop()
    {
        if (stack.Count == 0)
            Console.WriteLine("Stack is empty. Cannot pop.");
        else
            Console.WriteLine("Popped Element: " + stack.Pop());
    }

    // 5. Reverse string using stack
    static void ReverseString(string input)
    {
        Stack<char> charStack = new Stack<char>();

        foreach (char c in input)
            charStack.Push(c);

        string reversed = "";
        while (charStack.Count > 0)
            reversed += charStack.Pop();

        Console.WriteLine("Reversed String: " + reversed);
    }

    static void PrintStack()
    {
        foreach (int item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}