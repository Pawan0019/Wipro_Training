//List Exercise

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            10, 25, 60, 5, 90, 40, 55, 30
        };

        // Remove all numbers greater than 50
        numbers.RemoveAll(n => n > 50);

        Console.WriteLine("Remaining elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}



using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 40, 25, 90, 60, 90 };

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num < largest && num > secondLargest)
            {
                secondLargest = num;
            }
        }

        if (secondLargest == int.MinValue)
            Console.WriteLine("Second largest element not found");
        else
            Console.WriteLine("Second largest element: " + secondLargest);
    }
}



//LinkedList Exercise
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> names = new LinkedList<string>();

        names.AddFirst("Rahul");
        names.AddLast("Amit");
        names.AddLast("Neha");
        names.AddFirst("Priya");

        // Remove first element
        names.RemoveFirst();

        Console.WriteLine("Linked List elements:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}


//Dictionary Exercise
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> employees = new Dictionary<int, string>();

        employees.Add(101, "Rahul");
        employees.Add(102, "Anita");
        employees.Add(103, "Vikas");
        employees.Add(104, "Neha");
        employees.Add(105, "Aman");

        Console.Write("Enter EmployeeId to search: ");
        int id = int.Parse(Console.ReadLine());

        if (employees.ContainsKey(id))
            Console.WriteLine("Employee Name: " + employees[id]);
        else
            Console.WriteLine("Employee not found");
    }
}




using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> students = new Dictionary<string, int>
        {
            { "Rahul", 75 },
            { "Anita", 82 },
            { "Vikas", 60 },
            { "Neha", 90 },
            { "Aman", 55 }
        };

        int total = 0;
        foreach (int marks in students.Values)
        {
            total += marks;
        }

        double average = total / (double)students.Count;

        Console.WriteLine("Average Marks: " + average);
        Console.WriteLine("Students scoring above average:");

        foreach (var student in students)
        {
            if (student.Value > average)
            {
                Console.WriteLine(student.Key + " -> " + student.Value);
            }
        }
    }
}