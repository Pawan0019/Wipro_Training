using System.Reflection;

class Program
{
    static void Main()
    {
        // Get Type information
        Type type = typeof(Student);

        Console.WriteLine("Class Name: " + type.Name);

        // List properties
        Console.WriteLine("Properties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        // List methods
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        // Create object dynamically
        object obj = Activator.CreateInstance(type);

        // Set property values using reflection
        type.GetProperty("Name").SetValue(obj, "Rahul");

        // Call method dynamically
        MethodInfo displayMethod = type.GetMethod("Display");
        displayMethod.Invoke(obj, null);
    }
}