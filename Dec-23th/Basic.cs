public class Program
{
   public static void Main()
   {
       Console.WriteLine("Hello, World");
       int i = 10;
       int j = 20;
       int sum = i + j;
       Console.WriteLine(sum);

        // Grading system

        int score = 80;
        if(score >= 90)
        {
           Console.WriteLine("Grade A");
        }
        else if (score >= 75)
        {
           Console.WriteLine("Grade B");
        }
        else
        {
           Console.WriteLine("failed");
        }

        // admin access

        bool loggedIn = true;
        bool isAdmin = false;
        if (loggedIn)
        {
           if (isAdmin)
           {
               Console.WriteLine("Admin access");
           }
           else
           {
               Console.WriteLine("User access");
           }
        }

        // switch condition 

        int day = 3;
        switch (day)
        {
           case 1:
               Console.WriteLine("Mon");
               break;
           case 2:
               Console.WriteLine("Tue");
               break;
           case 3:
               Console.WriteLine("Wed");
               break;
           default:
               Console.WriteLine("Invalid day");
               break;
        }

        // Even - Odd
        int number = 7;
        string result;
        if (number % 2 == 0)
        {
        result = "Even";  // string result = (number % 2 == 0) ? "Even": "Odd";
        }
        else
        {
        result = "Odd";
        }
        Console.WriteLine(result);
   }
}