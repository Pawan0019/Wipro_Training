using System.Collections.Generic;

public class Dictionary
{
    static void Main()
    {

        //Dictionary<int, string> students = new Dictionary<int, string>();
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {101, "Amit" },
            {102, "Neha" },
            {103, "Rahul" }
        };

        students.Add(104, "Priya");

        if (!students.ContainsKey(105))
        {
            students.Add{ 105, "Sonal"}

        }

        if (students.ContainsKey(102))
            Console.WriteLine(students[102]);

        students[101] = "Amit Kumar"; //update

        students.Remove(102);

        foreach(KeyValuePair<int, string> item in students)
        {
            Console.WriteLine(item.Key + " - " + item.Value);
        }

    }
}