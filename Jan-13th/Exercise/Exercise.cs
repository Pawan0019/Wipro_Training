using System;
using Microsoft.Data.SqlClient;

class Program
{
    static string connectionString =
        "Server=localhost;Database=AdoNetDemoDB;Trusted_Connection=True;TrustServerCertificate=True";

    static void Main()
    {
        Console.WriteLine("ADO.NET CRUD OPERATIONS\n");

        int id1 = InsertOrder("Pawan", "Laptop", 1, 70000);
        int id2 = InsertOrder("Rahul", "Mobile", 2, 40000);
        int id3 = InsertOrder("Anita", "Tablet", 1, 30000);

        Console.WriteLine("\n--- After Insert ---");
        ReadOrders();

        UpdateOrder(id2, 3, 60000);
        Console.WriteLine("\n--- After Update ---");
        ReadOrders();

        DeleteOrder(id1);
        Console.WriteLine("\n--- After Delete ---");
        ReadOrders();

        ShowTotalOrders();
        ShowHighestAmount();
    }

    // 1. INSERT + SCOPE_IDENTITY
    static int InsertOrder(string customer, string product, int qty, decimal amount)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = @"
            INSERT INTO Orders VALUES
            (@CustomerName,@ProductName,@Quantity,@TotalAmount,GETDATE());
            SELECT SCOPE_IDENTITY();";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@CustomerName", customer);
        cmd.Parameters.AddWithValue("@ProductName", product);
        cmd.Parameters.AddWithValue("@Quantity", qty);
        cmd.Parameters.AddWithValue("@TotalAmount", amount);

        con.Open();
        int newId = Convert.ToInt32(cmd.ExecuteScalar());
        Console.WriteLine($"Inserted OrderId: {newId}");
        return newId;
    }

    // READ
    static void ReadOrders()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(
                $"ID:{dr["OrderId"]}, Customer:{dr["CustomerName"]}, Product:{dr["ProductName"]}, Qty:{dr["Quantity"]}, Amount:{dr["TotalAmount"]}");
        }
    }

    // 3. UPDATE + @@ROWCOUNT
    static void UpdateOrder(int id, int qty, decimal amount)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = @"
            UPDATE Orders
            SET Quantity=@Quantity, TotalAmount=@TotalAmount
            WHERE OrderId=@OrderId;
            SELECT @@ROWCOUNT;";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Quantity", qty);
        cmd.Parameters.AddWithValue("@TotalAmount", amount);
        cmd.Parameters.AddWithValue("@OrderId", id);

        con.Open();
        int rows = Convert.ToInt32(cmd.ExecuteScalar());
        Console.WriteLine($"Updated Rows: {rows}");
    }

    // 2. DELETE + @@ROWCOUNT
    static void DeleteOrder(int id)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = @"
            DELETE FROM Orders WHERE OrderId=@OrderId;
            SELECT @@ROWCOUNT;";

        SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@OrderId", id);

        con.Open();
        int rows = Convert.ToInt32(cmd.ExecuteScalar());
        Console.WriteLine($"Deleted Rows: {rows}");
    }

    // 4. COUNT(*)
    static void ShowTotalOrders()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", con);

        con.Open();
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        Console.WriteLine($"\nTotal Orders: {count}");
    }

    // 5. MAX(TotalAmount)
    static void ShowHighestAmount()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT MAX(TotalAmount) FROM Orders", con);

        con.Open();
        decimal max = Convert.ToDecimal(cmd.ExecuteScalar());
        Console.WriteLine($"Highest Order Amount: {max}");
    }
}