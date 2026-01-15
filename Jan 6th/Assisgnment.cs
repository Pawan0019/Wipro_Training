using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names =
        {
            "Amit",
            "Ananya",
            "Rahul",
            "Sneha",
            "Sanjay",
            "Priya",
            "Kiran",
            "Arjun",
            "Neha",
            "Suman",
            "Ravi",
            "Anil",
            "Pooja",
            "Ramesh",
            "Kavita",
            "Amit",   // duplicate on purpose
            "Sonia"
        };

        // 1. Select and print all names
        Console.WriteLine("1. All Names:");
        names.ToList().ForEach(n => Console.WriteLine(n));

        // 2. Names starting with 'A'
        Console.WriteLine("\n2. Names starting with 'A':");
        var startWithA = names.Where(n => n.StartsWith("A"));
        foreach (var name in startWithA)
            Console.WriteLine(name);

        // 3. Names with length greater than 5
        Console.WriteLine("\n3. Names with length > 5:");
        var lengthGreaterThan5 = names.Where(n => n.Length > 5);
        foreach (var name in lengthGreaterThan5)
            Console.WriteLine(name);

        // 4. Convert all names to uppercase
        Console.WriteLine("\n4. Names in Uppercase:");
        var upperCaseNames = names.Select(n => n.ToUpper());
        foreach (var name in upperCaseNames)
            Console.WriteLine(name);

        // 5. Sort names in ascending order
        Console.WriteLine("\n5. Names in Ascending Order:");
        var ascending = names.OrderBy(n => n);
        foreach (var name in ascending)
            Console.WriteLine(name);

        // 6. Sort names in descending order
        Console.WriteLine("\n6. Names in Descending Order:");
        var descending = names.OrderByDescending(n => n);
        foreach (var name in descending)
            Console.WriteLine(name);

        // 7. First name starting with 'S'
        Console.WriteLine("\n7. First name starting with 'S':");
        var firstS = names.FirstOrDefault(n => n.StartsWith("S"));
        Console.WriteLine(firstS ?? "No name found");

        // 8. Check if any name contains "an"
        Console.WriteLine("\n8. Any name contains 'an':");
        bool containsAn = names.Any(n => n.ToLower().Contains("an"));
        Console.WriteLine(containsAn);

        // 9. Count names with exactly 4 characters
        Console.WriteLine("\n9. Count of names with exactly 4 characters:");
        int countFourChars = names.Count(n => n.Length == 4);
        Console.WriteLine(countFourChars);

        // 10. Distinct names
        Console.WriteLine("\n10. Distinct Names:");
        var distinctNames = names.Distinct();
        foreach (var name in distinctNames)
            Console.WriteLine(name);
    }
}
