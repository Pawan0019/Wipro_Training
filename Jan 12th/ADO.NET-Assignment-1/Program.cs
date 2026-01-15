using System;
using Microsoft.Data.SqlClient;

class Program
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
       }
       Console.ReadLine();
   }
}