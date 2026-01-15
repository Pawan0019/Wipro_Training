class Exercise
{
    public static void Main()
    {
        // 1 & 3: Number greater than 50 and even/odd
        CheckNumberConditions();

        // 2: Age above 60
        CheckAgeAbove60();

        CheckPassFail_Ternary();     // Q4 (Ternary Operator)
        AssignGrade_Switch();        // Q5 (Switch Case)

        // 6: Largest of three numbers
        FindLargestOfThree();

        // 7: Login validation
        ValidateLogin();

        // 8: Loan eligibility
        CheckLoanEligibility();
    }

    // Question 1 & 3
    static void CheckNumberConditions()
    {
        
        int num = 50;

        if (num > 50)
            Console.WriteLine("Number is greater than 50");
        else
            Console.WriteLine("Number is not greater than 50");

        if (num % 2 == 0)
            Console.WriteLine("Number is Even");
        else
            Console.WriteLine("Number is Odd");
    }

    // Question 2
    static void CheckAgeAbove60()
    {
        
        int age = 60;

        if (age > 60)
            Console.WriteLine("Age is above 60");
        else
            Console.WriteLine("Age is 60 or below");
    }

    // Question 4 - Pass / Fail using Ternary Operator
    static void CheckPassFail_Ternary()
    {

        int marks = 50;

        string result = (marks > 40) ? "Pass" : "Fail";
        Console.WriteLine("Result: " + result);
    }

    // Question 5 - Grade Assignment using Switch Case
    static void AssignGrade_Switch()
    {

        int marks = 90;

        switch (marks / 10)
        {
            case 10:
            case 9:
            case 8:
                Console.WriteLine("Grade: Distinction");
                break;

            case 7:
            case 6:
                Console.WriteLine("Grade: First Class");
                break;

            case 5:
            case 4:
                Console.WriteLine("Grade: Pass");
                break;

            default:
                Console.WriteLine("Grade: Fail");
                break;
        }
    }

    // Question 6
    static void FindLargestOfThree()
    {
        int a = 60;

        int b = 67;

        int c = 90;

        int largest = a;

        if (b > largest)
            largest = b;
        if (c > largest)
            largest = c;

        Console.WriteLine("Largest number is: " + largest);
    }

    // Question 7
    static void ValidateLogin()
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        string username = "pawan";

        if (username == correctUsername)
        {
            string password = 1234;

            if (password == correctPassword)
                Console.WriteLine("Login successful");
            else
                Console.WriteLine("Incorrect password");
        }
        else
        {
            Console.WriteLine("Invalid username");
        }
    }

    // Question 8
    static void CheckLoanEligibility()
    {
        int age = 22;
        int salary = 60000;

        if (age >= 21 && salary >= 30000)
            Console.WriteLine("Eligible for loan");
        else
            Console.WriteLine("Not eligible for loan");
    }
}
