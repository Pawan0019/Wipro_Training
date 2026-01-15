using System;
using System.Collections.Generic;

class ListExercise2
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 21, 32, 43, 54, 65, 76, 87, 98, 109};

        PrintEvenNumbers(numbers);
        RemoveOddNumbers(numbers);
        FindSumAndAverage(numbers);
        ReverseList(numbers);
        FindSecondLargest(numbers);
    }

    // 1. Print even numbers
    static void PrintEvenNumbers(List<int> numbers)
    {
        Console.WriteLine("Even Numbers:");
        foreach (int n in numbers)
        {
            if (n % 2 == 0)
                Console.Write(n + " ");
        }
        Console.WriteLine("\n");
    }

    // 2. Remove all odd numbers
    static void RemoveOddNumbers(List<int> numbers)
    {
        numbers.RemoveAll(n => n % 2 != 0);
        Console.WriteLine("After Removing Odd Numbers:");
        foreach (int n in numbers)
            Console.Write(n + " ");
        Console.WriteLine("\n");
    }

    // 3. Sum and Average
    static void FindSumAndAverage(List<int> numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
            sum += n;

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}\n");
    }

    // 4. Reverse list without Reverse()
    static void ReverseList(List<int> numbers)
    {
        Console.WriteLine("Reversed List:");
        for (int i = numbers.Count - 1; i >= 0; i--)
            Console.Write(numbers[i] + " ");
        Console.WriteLine("\n");
    }

    // 5. Second largest element without sorting
    static void FindSecondLargest(List<int> numbers)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int n in numbers)
        {
            if (n > largest)
            {
                secondLargest = largest;
                largest = n;
            }
            else if (n > secondLargest && n != largest)
            {
                secondLargest = n;
            }
        }

        Console.WriteLine($"Second Largest Element: {secondLargest}");
    }
}