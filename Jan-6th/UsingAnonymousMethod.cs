
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Shiva", "Naresh", "Suresh", "Suman" };

        //Using LINQ Queries
        UsingAnonymousMethods(names);
    }

    private static void UsingAnonymousMethods(string[] names)
    {
        Func<string, bool> filter = delegate (string s)
        {
            //more lines of code
            return s.Length == 5;

        };
        Func<string, string> project = delegate (string s)
        {
            return s.ToUpper();
        };

        Func<string, string> extract = delegate (string s)
        {
            return s;
        };

        IEnumerable<string> query = names.Where(filter).OrderBy(extract).Select(project);

        foreach (string item in query)
            Console.WriteLine(item);

        Console.ReadLine();
    }
}