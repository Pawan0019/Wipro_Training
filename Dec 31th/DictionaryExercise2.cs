using System;
using System.Collections.Generic;

class DictionaryExercise2
{
    static void Main()
    {
        StudentDictionary();
        ProductCost();
        WordFrequency();
        EmployeeSalary();
        KeyCheck();
    }

    // 1. Student dictionary
    static void StudentDictionary()
    {
        Dictionary<int, string> students = new Dictionary<int, string>()
        {
            {101, "Amit"},
            {102, "Neha"},
            {103, "Rahul"},
            {104, "Pooja"},
            {105, "Karan"}
        };
        int searchId = 103;
        Console.WriteLine($"Student with ID {searchId}: {students[searchId]}\n");
    }

    // 2. Total cost of products
    static void ProductCost()
    {
        Dictionary<string, double> products = new Dictionary<string, double>()
        {
            {"Laptop", 55000},
            {"Mouse", 500},
            {"Keyboard", 1200},
            {"Monitor", 8000}
        };

        double total = 0;
        foreach (var item in products)
            total += item.Value;

        Console.WriteLine($"Total Product Cost: {total}\n");
    }

    // 3. Word frequency
    static void WordFrequency()
    {
        string sentence = "c sharp is easy and c sharp is powerful";
        string[] words = sentence.Split(' ');

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        Console.WriteLine("Word Frequency:");
        foreach (var item in frequency)
            Console.WriteLine($"{item.Key} : {item.Value}");
        Console.WriteLine();
    }

    // 4. Employees earning above average salary
    static void EmployeeSalary()
    {
        Dictionary<string, double> employees = new Dictionary<string, double>()
        {
            {"Ravi", 40000},
            {"Sita", 55000},
            {"Aman", 60000},
            {"Nina", 45000}
        };

        double sum = 0;
        foreach (var e in employees)
            sum += e.Value;

        double average = sum / employees.Count;

        Console.WriteLine($"Average Salary: {average}");
        Console.WriteLine("Employees earning above average:");

        foreach (var e in employees)
        {
            if (e.Value > average)
                Console.WriteLine(e.Key);
        }
        Console.WriteLine();
    }

    // 5. Check key existence and safe retrieval
    static void KeyCheck()
    {
        Dictionary<string, string> data = new Dictionary<string, string>()
        {
            {"admin", "active"},
            {"user", "inactive"}
        };

        string key = "admin";

        if (data.TryGetValue(key, out string value))
            Console.WriteLine($"Key '{key}' exists with value: {value}");
        else
            Console.WriteLine($"Key '{key}' does not exist");
    }
}