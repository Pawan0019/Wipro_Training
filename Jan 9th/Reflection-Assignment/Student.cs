using System;
using System.Reflection;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}
