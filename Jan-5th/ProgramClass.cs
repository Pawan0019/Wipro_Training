using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1;
class Program
{
    static async Task Main()
    {
        //ConsoleApp1.Student s1 = new ConsoleApp1.Student();
        Student s1 = new Student();

        s1.Study();
        s1.Speak();
        s1.Display();

        s1.Id = 1;
        s1.Name = "Rahul";

        s1.Display();

        Calculator c1 = new Calculator();
        int num1 = 30;
        int num2 = 10;

        Console.WriteLine("Addition is " + c1.add(num1, num2));

        Console.WriteLine("Subraction is " + c1.sub(num1, num2));

        Console.WriteLine("Multiplication is " + c1.mul(num1, num2));

        Console.WriteLine("Division is " + c1.div(num1, num2));
    }
}
