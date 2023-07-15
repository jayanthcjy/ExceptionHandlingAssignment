using System;
using System.Data.SqlClient;
using System.Data;

class DatabaseOperationsApp
{
    static void Main()
    {
        // string connectionString = "Your_Connection_String";
        string connectionString = "Server=COGNINE-L35;Database=Jayanth;Integrated Security=True;";

        try
        {
            // Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                Console.WriteLine("Database operations completed successfully!");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("A database error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}











//// Create a SqlCommand to execute the query
//string query = "SELECT Name FROM sam WHERE Age > 25";
//using (SqlCommand command = new SqlCommand(query, connection))
//{
//    // Execute the query and retrieve the results
//    using (SqlDataReader reader = command.ExecuteReader())
//    {
//        // Store the names in a list
//        List<string> names = new List<string>();
//        while (reader.Read())
//        {
//            string name = (string)reader["Name"];
//            names.Add(name);
//        }

//        // Process the names as needed
//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}