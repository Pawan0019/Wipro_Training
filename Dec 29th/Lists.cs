using System.Collections.Generic;

public class Program
{
    static void Main()
    {

        //List<int> numbers = new List<int>();
        List<int> numbers = new List<int> { 10,20,30};

        numbers.Add(40);
        numbers.AddRange(new int[] { 50, 60 });
        Console.WriteLine(numbers[0]);
        numbers[1] = 25;

        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        numbers.Insert(1, 15);

        Console.WriteLine(numbers);

        numbers.Remove(30);

        numbers.RemoveAt(2);

        Console.WriteLine(numbers);

        numbers.RemoveRange(1, 2);

        bool exists = numbers.Contains(40);

        int index = numbers.IndexOf(25);

        //numbers.Clear();

        numbers.Sort();

        numbers.Reverse();

        //foreach (int n in numbers)
        //{
        //    Console.WriteLine(n);
        //}

        Console.WriteLine(string.Join("  ", numbers));



    }
}