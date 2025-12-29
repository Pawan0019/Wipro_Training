public class Program
{
    static int ReadMarks()
    {
        return 75;
    }

    static string CalculateGrade(int marks)
    {
        return marks >= 50 ? "Pass" : "Fail";
    }

    static void DisplayResult(string grade)
    {
        Console.WriteLine(grade);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void sum_all()
    {
        int n = 5;
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine(sum);
    }

    static int Factorial(int n)
    {
        if (n = 0)
        return 1;
        return n * Factorial(n-1);
    }
    
    public static void Main()
    {
        int result Add(10, 20);
        Console.WriteLine(result);
        Console.WriteLine(sum_all);
        int marks = ReadMarks();
        string grade = CalculateGrade(marks);
        DisplayResult(grade);
        Console.WriteLine(Factorial(5));
    }
}