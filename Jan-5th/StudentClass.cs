using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Person
    {
        public string Name;

        public void Speak()
        {
            Console.WriteLine("Person is speaking");
        }
    }
    class Student : Person
    {
        public int Id;
        public string Name;

        public Student(int i, string s)
        {
           Id = i;
           Name = s;
        }

        public void Display()
        {
            
           Console.WriteLine("Id: " + Id);
           Console.WriteLine("Name:" + Name);
        }

        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }
}