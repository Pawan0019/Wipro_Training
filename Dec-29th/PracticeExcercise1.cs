using System;
using System.Collections.Generic;

class PracticeExercise1
{
    static void Main()
    {
        Console.WriteLine("1) Palindrome Number Check");
        Console.Write("Enter a number: ");
        long num = ReadLong();
        Console.WriteLine(IsPalindromeNumber(num) ? "Palindrome" : "Not Palindrome");

        Console.WriteLine("\n2) Count Vowels and Consonants");
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";
        CountVowelsAndConsonants(input, out int vowels, out int consonants);
        Console.WriteLine($"Vowels: {vowels}");
        Console.WriteLine($"Consonants: {consonants}");

        Console.WriteLine("\n3) Frequency of Each Element in an Integer Array");
        int[] arr = ReadIntArrayFromUser();
        var freq = FrequencyCount(arr);
        Console.WriteLine("Frequencies:");
        foreach (var kv in freq)
            Console.WriteLine($"{kv.Key} -> {kv.Value}");

        Console.WriteLine("\n4) Remove Duplicates from an Array");
        int[] unique = RemoveDuplicatesPreserveOrder(arr);
        Console.WriteLine("Array after removing duplicates (order preserved):");
        Console.WriteLine(string.Join(" ", unique));

        Console.WriteLine("\n5) Second Largest Element Without Sorting");
        if (TryGetSecondLargest(arr, out int secondLargest))
            Console.WriteLine($"Second largest: {secondLargest}");
        else
            Console.WriteLine("Second largest not possible (need at least 2 distinct values).");

        Console.WriteLine("\nDone. Press Enter to exit.");
        Console.ReadLine();
    }

    // -------------------- 1) Palindrome Number --------------------
    static bool IsPalindromeNumber(long n)
    {
        if (n < 0) return false; // negative numbers are not palindrome
        long original = n;
        long reversed = 0;

        while (n > 0)
        {
            long digit = n % 10;
            reversed = reversed * 10 + digit;
            n /= 10;
        }

        return original == reversed;
    }

    // -------------------- 2) Vowels & Consonants --------------------
    static void CountVowelsAndConsonants(string s, out int vowels, out int consonants)
    {
        vowels = 0;
        consonants = 0;

        foreach (char ch in s)
        {
            if (!char.IsLetter(ch)) continue; // ignore spaces, digits, symbols

            char c = char.ToLower(ch);
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                vowels++;
            else
                consonants++;
        }
    }

    // -------------------- 3) Frequency Count --------------------
    static Dictionary<int, int> FrequencyCount(int[] arr)
    {
        var dict = new Dictionary<int, int>();
        foreach (int x in arr)
        {
            if (dict.ContainsKey(x)) dict[x]++;
            else dict[x] = 1;
        }
        return dict;
    }

    // -------------------- 4) Remove Duplicates --------------------
    // Preserves original order using HashSet
    static int[] RemoveDuplicatesPreserveOrder(int[] arr)
    {
        var seen = new HashSet<int>();
        var result = new List<int>();

        foreach (int x in arr)
        {
            if (seen.Add(x)) // add returns false if already exists
                result.Add(x);
        }

        return result.ToArray();
    }

    // -------------------- 5) Second Largest (No Sorting) --------------------
    static bool TryGetSecondLargest(int[] arr, out int secondLargest)
    {
        secondLargest = 0;
        if (arr == null || arr.Length < 2) return false;

        int largest = int.MinValue;
        int second = int.MinValue;

        foreach (int x in arr)
        {
            if (x > largest)
            {
                second = largest;
                largest = x;
            }
            else if (x < largest && x > second) // < largest ensures distinct value
            {
                second = x;
            }
        }

        if (second == int.MinValue) return false; // no second distinct value
        secondLargest = second;
        return true;
    }

    // -------------------- Input Helpers --------------------
    static long ReadLong()
    {
        while (true)
        {
            string? s = Console.ReadLine();
            if (long.TryParse(s, out long val)) return val;
            Console.Write("Invalid input. Enter a valid number: ");
        }
    }

    static int[] ReadIntArrayFromUser()
    {
        Console.WriteLine("\nEnter array elements separated by spaces (example: 10 20 10 30):");
        while (true)
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.Write("Empty input. Enter again: ");
                continue;
            }

            string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var list = new List<int>();
            bool ok = true;

            foreach (string p in parts)
            {
                if (int.TryParse(p, out int val)) list.Add(val);
                else { ok = false; break; }
            }

            if (ok && list.Count > 0) return list.ToArray();
            Console.Write("Invalid input. Enter integers separated by spaces: ");
        }
    }
}
