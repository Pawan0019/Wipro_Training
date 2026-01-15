using System;
public class Array
{
    static void Main()
    {
        int[] arr = { 20, 30, 40, 50 };
        int sum = 0;

        for(int i = 0; i < arr.Length; i++)
        {
           sum += arr[i];
        }
        Console.WriteLine("sum of array elements: "+ sum);

        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine()!);

        if (n > 0) Console.WriteLine("Positive");
        else if (n < 0) Console.WriteLine("Negative");
        else Console.WriteLine("Zero");

        Console.WriteLine("Enter the total number");
        int n = int.Parse(Console.ReadLine()!);

        if (n >= 40) Console.WriteLine("Passed");
        else Console.WriteLine("Failed");


        int[] arr = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < arr.Length; i++)
        {
           Console.WriteLine(arr[i] + " ");
        }

        int[] arr = { 5, 10, 15 };
        int sum = 0;
        for(int i=0;i<arr.Length; i++)
        {
           sum += arr[i];
        }
        Console.WriteLine(sum);

        int[] arr = { 12, 45, 7, 89, 23 };
        int max = arr[0];

        for(int i = 1; i < arr.Length; i++)
        {
           if (arr[i] > max)
           {
               max = arr[i];
           }
        }
        Console.WriteLine(max);

        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int even = 0, odd = 0;

        for (int i = 0; i<arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even Count: " + even);
        Console.WriteLine("Odd Count: " + odd);
    }
}
