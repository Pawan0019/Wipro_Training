using System;
using System.Collections.Generic;

class DictionaryExercise
{
    static void Main()
    {
        CalculateTotalProductPrice();
        FindTopStudent();
        CharacterFrequency();
    }

    // 1 Dictionary Exercise: Total Price of Products
    static void CalculateTotalProductPrice()
    {
        Dictionary<int, double> products = new Dictionary<int, double>
        {
            { 101, 299.99 },
            { 102, 499.50 },
            { 103, 150.75 },
            { 104, 799.00 }
        };

        double total = 0;

        foreach (double price in products.Values)
        {
            total += price;
        }

        Console.WriteLine("Total price of all products: " + total);
        Console.WriteLine("--------------------------------");
    }

    // 2 Dictionary Exercise: Find Top Student
    static void FindTopStudent()
    {
        Dictionary<string, int> students = new Dictionary<string, int>
        {
            { "Rahul", 75 },
            { "Anita", 88 },
            { "Vikas", 69 },
            { "Neha", 92 },
            { "Aman", 81 }
        };

        string topStudent = "";
        int highestMarks = int.MinValue;

        foreach (var student in students)
        {
            if (student.Value > highestMarks)
            {
                highestMarks = student.Value;
                topStudent = student.Key;
            }
        }

        Console.WriteLine("Top Student: " + topStudent);
        Console.WriteLine("Highest Marks: " + highestMarks);
        Console.WriteLine("--------------------------------");
    }

    // 3 Dictionary Exercise: Character Frequency
    static void CharacterFrequency()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        Console.WriteLine("Character Frequencies:");
        foreach (var item in freq)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}