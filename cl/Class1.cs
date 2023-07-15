using System.IO;
using System.Data.SqlClient;

class DatabaseOperationsApp
{
    static void Main()
    {
        string connectionString = "Your_Connection_String";

        try
        {
            // Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Perform database operations
                // ...

                Console.WriteLine("Database operations completed successfully!");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("A database error occurred: " + ex.Message);
            // Additional error handling or logging can be performed here
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}
