using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    internal class employee
    {
       public int Id;
       public string Name;

       public void DisplayDetails()
       {
           Console.WriteLine("DisplayEmployee details");
       }

    }

    internal class Manager : employee
    {
       public string Department;

       public void ShowDepartment()
       {
           Console.WriteLine("Show the department");
       }
    }

    public class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle starts");
        }
    }

    public class Bike : Vehicle 
    {
        public void Start()
        {
            Console.WriteLine("Bike starts");
        }
    }

    public class Car : Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Car starts");
        }
    }

}