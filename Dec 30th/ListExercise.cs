using System;
using System.Collections.Generic;

class ListExercise
{
    static void Main()
    {
        PrintNumbersDivisibleBy3();
        RemoveDuplicatesFromList();
        FindLargestAndSmallest();
    }

    // 1 List Exercise: Numbers Divisible by 3
    static void PrintNumbersDivisibleBy3()
    {
        List<int> numbers = new List<int>
        {
            3, 5, 9, 12, 14, 18, 20, 21, 25, 30
        };

        Console.WriteLine("Numbers divisible by 3:");
        foreach (int num in numbers)
        {
            if (num % 3 == 0)
                Console.Write(num + " ");
        }
        Console.WriteLine("\n--------------------------------");
    }

    // 2 List Exercise: Remove Duplicates
    static void RemoveDuplicatesFromList()
    {
        List<int> numbers = new List<int>
        {
            10, 20, 10, 30, 40, 20, 50
        };

        HashSet<int> unique = new HashSet<int>(numbers);

        Console.WriteLine("List after removing duplicates:");
        foreach (int num in unique)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n--------------------------------");
    }

    // 3 List Exercise: Find Largest and Smallest
    static void FindLargestAndSmallest()
    {
        List<int> numbers = new List<int>
        {
            45, 12, 78, 34, 9, 66
        };

        int largest = numbers[0];
        int smallest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
                largest = num;

            if (num < smallest)
                smallest = num;
        }

        Console.WriteLine("Largest: " + largest);
        Console.WriteLine("Smallest: " + smallest);
    }
}