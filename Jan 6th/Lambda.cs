
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Shiva", "Naresh", "Suresh", "Suman" };

        //Using LINQ Queries
        UsingLINQFunctions(names);
    }

    private static void UsingLINQFunctions(string[] names)
    {
        Func<string, bool> filter = s => s.Length == 5;
        Func<string, bool> extract = s => s;
        Func<string, bool> project = s => s.ToUpper();
        IEnumerable<string> query = names.Where(filter)
                                         .OrderBy(extract)
                                         .Select(project);

        //select *from
        foreach (string item in query)
            Console.WriteLine(item);

        Console.Read();
    }
}