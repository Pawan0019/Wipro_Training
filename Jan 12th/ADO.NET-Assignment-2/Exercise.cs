using System;
using Microsoft.Data.SqlClient;

class Exercise
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True";
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "SELECT * FROM Products";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(
                    reader["ProductId"] + " | " +
                    reader["Name"] + " | " +
                    reader["Price"] + " | " +
                    reader["Quantity"]);
            }
            reader.Close();

            InsertData();
            UpdateData();
            DeleteData();

            // INSERT DATA
            static void InsertData()
            {
                string connectionString =
                    "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Products (Name, Price, Quantity) VALUES ('Headphones', 2000, 15)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Inserted Successfully");
                }
            }

            // UPDATE DATA
            static void UpdateData()
            {
                string connectionString =
                    "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Products SET Price = 1800 WHERE ProductId = 1";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Updated Successfully");
                }
            }

            // DELETE DATA
            static void DeleteData()
            {
                string connectionString =
                    "Server=localhost;Database=ShopDB;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Products WHERE ProductId = 3";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data Deleted Successfully");
                }
            }
        }
    }
}