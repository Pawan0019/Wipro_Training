using System;

class Exercise
{
    // Section 1: Basic Logic
    static void PrintNumbers1To10()
    {
        for (int i = 1; i <= 10; i++)
            Console.Write(i + " ");
        Console.WriteLine();
    }

    static void CheckEvenOdd(int num)
    {
        Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
    }

    // Section 2: Arrays
    static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    static void SumOfArray(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr)
            sum += x;
        Console.WriteLine(sum);
    }

    // Section 3: Conditionals
    static void CheckNumberType(int num)
    {
        if (num > 0)
            Console.WriteLine("Positive");
        else if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }

    static void CheckPassFail(int marks)
    {
        Console.WriteLine(marks >= 40 ? "Passed" : "Failed");
    }

    // Section 4: Loops
    static void MultiplicationTable(int n)
    {
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void CountGreaterThan50(int[] arr)
    {
        int count = 0;
        foreach (int x in arr)
        {
            if (x > 50)
                count++;
        }
        Console.WriteLine(count);
    }

    // Section 5: Functions
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    // Section 6: Searching
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    // Main Method
    static void Main()
    {
        Console.WriteLine("Section 1:");
        PrintNumbers1To10();
        CheckEvenOdd(7);

        Console.WriteLine("\nSection 2:");
        int[] arr1 = { 10, 20, 30, 40 };
        PrintArray(arr1);
        SumOfArray(new int[] { 5, 10, 15 });

        Console.WriteLine("\nSection 3:");
        CheckNumberType(-3);
        CheckPassFail(55);

        Console.WriteLine("\nSection 4:");
        MultiplicationTable(5);
        CountGreaterThan50(new int[] { 10, 55, 70, 20, 90 });

        Console.WriteLine("\nSection 5:");
        Console.WriteLine(Add(3, 4));
        Console.WriteLine(Max(10, 20));

        Console.WriteLine("\nSection 6:");
        Console.WriteLine(LinearSearch(new int[] { 4, 2, 7, 1 }, 7));
        Console.WriteLine(BinarySearch(new int[] { 1, 3, 5, 7, 9 }, 5));
    }
}