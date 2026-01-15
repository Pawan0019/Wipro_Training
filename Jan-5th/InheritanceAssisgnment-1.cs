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
}