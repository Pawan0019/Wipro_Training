using System;
using System.Data.SqlClient;

namespace ADOStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection String
            string connectionString =
                "Server=localhost;Database=StudentDB;Trusted_Connection=True;";

            // SQL Query
            string query = "SELECT * FROM Students";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    Console.WriteLine("Student List:\n");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"ID: {reader["StudentId"]}, " +
                            $"Name: {reader["Name"]}, " +
                            $"Age: {reader["Age"]}, " +
                            $"Course: {reader["Course"]}"
                        );
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
