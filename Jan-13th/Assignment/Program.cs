using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        // ---------- INSERT ----------
        string insertConnectionString =
            "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        using (SqlConnection con = new SqlConnection(insertConnectionString))
        {
            con.Open();

            string insertQuery = @"
                INSERT INTO Products (Name, Price, Quantity)
                VALUES (@Name, @Price, @Quantity)";

            using (SqlCommand cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.AddWithValue("@Name", "Headphones");
                cmd.Parameters.AddWithValue("@Price", 2500.00);
                cmd.Parameters.AddWithValue("@Quantity", 15);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " record inserted successfully.");
            }
        }

        // ---------- UPDATE ----------
        string updateConnectionString =
            "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=False;";

        using (SqlConnection con = new SqlConnection(updateConnectionString))
        {
            con.Open();

            string updateQuery = @"
                UPDATE Products
                SET Price = @Price, Quantity = @Quantity
                WHERE Name = @Name";

            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
            {
                cmd.Parameters.AddWithValue("@Price", 2200.00);
                cmd.Parameters.AddWithValue("@Quantity", 20);
                cmd.Parameters.AddWithValue("@Name", "Headphones");

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " record updated successfully.");
            }
        }

        // ---------- DELETE ----------
        string deleteConnectionString =
            "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=False;";

        using (SqlConnection con = new SqlConnection(deleteConnectionString))
        {
            con.Open();

            string deleteQuery = @"
                DELETE FROM Products
                WHERE Name = @Name";

            using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
            {
                cmd.Parameters.AddWithValue("@Name", "Headphones");

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " record deleted successfully.");
            }
        }

        Console.ReadLine();
    }
}