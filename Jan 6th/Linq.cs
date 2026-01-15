class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Shiva", "Naresh", "Suresh", "Suman" };

        //Using LINQ Queries
        UsingLinq(names);
    }

    private static void UsingLinq(string[] names)
    {
        IEnumerable<string> query = from s in names
                                    where s.Length == 5
                                    orderby s
                                    select s.ToUpper();

        //select *from
        foreach (string item in query)
            Console.WriteLine(item);

        Console.Read();
    }
}