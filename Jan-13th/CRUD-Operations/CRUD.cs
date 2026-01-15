using System;
using Microsoft.Data.SqlClient;

class CRUD
{
    static string connectionString =
        "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=False;";

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. View Employee By ID");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Delete Employee");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: InsertEmployee(); break;
                case 2: ViewAllEmployees(); break;
                case 3: ViewEmployeeById(); break;
                case 4: UpdateEmployee(); break;
                case 5: DeleteEmployee(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    // ---------------- INSERT ----------------
    static void InsertEmployee()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        string query = @"
            INSERT INTO Employees
            (Name, Email, Phone, Department, Salary, JoiningDate, IsActive)
            VALUES
            (@Name, @Email, @Phone, @Department, @Salary, @JoiningDate, @IsActive)";

        using SqlCommand cmd = new SqlCommand(query, con);

        Console.Write("Name: ");
        cmd.Parameters.AddWithValue("@Name", Console.ReadLine());

        Console.Write("Email: ");
        cmd.Parameters.AddWithValue("@Email", Console.ReadLine());

        Console.Write("Phone: ");
        cmd.Parameters.AddWithValue("@Phone", Console.ReadLine());

        Console.Write("Department: ");
        cmd.Parameters.AddWithValue("@Department", Console.ReadLine());

        Console.Write("Salary: ");
        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(Console.ReadLine()));

        Console.Write("Joining Date (yyyy-mm-dd): ");
        cmd.Parameters.AddWithValue("@JoiningDate", DateTime.Parse(Console.ReadLine()));

        Console.Write("Is Active (1/0): ");
        cmd.Parameters.AddWithValue("@IsActive", int.Parse(Console.ReadLine()));

        cmd.ExecuteNonQuery();
        Console.WriteLine("Employee inserted successfully.");
    }

    // ---------------- READ ALL ----------------
    static void ViewAllEmployees()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        string query = "SELECT * FROM Employees";
        using SqlCommand cmd = new SqlCommand(query, con);
        using SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(
                $"{dr["EmployeeId"]} | {dr["Name"]} | {dr["Department"]} | {dr["Salary"]}");
        }
    }

    // ---------------- READ BY ID ----------------
    static void ViewEmployeeById()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        string query = "SELECT * FROM Employees WHERE EmployeeId = @Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);

        using SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            Console.WriteLine($"Name: {dr["Name"]}");
            Console.WriteLine($"Email: {dr["Email"]}");
            Console.WriteLine($"Department: {dr["Department"]}");
            Console.WriteLine($"Salary: {dr["Salary"]}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }

    // ---------------- UPDATE ----------------
    static void UpdateEmployee()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("New Department: ");
        string dept = Console.ReadLine();

        Console.Write("New Salary: ");
        decimal salary = decimal.Parse(Console.ReadLine());

        string query = @"
            UPDATE Employees
            SET Department = @Department, Salary = @Salary
            WHERE EmployeeId = @Id";

        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Department", dept);
        cmd.Parameters.AddWithValue("@Salary", salary);
        cmd.Parameters.AddWithValue("@Id", id);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine(rows + " employee updated.");
    }

    // ---------------- DELETE ----------------
    static void DeleteEmployee()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        string query = "DELETE FROM Employees WHERE EmployeeId = @Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine(rows + " employee deleted.");
    }
}
