using System;
using System.IO;
using System.IO.Pipes;

class FileProcessingApp
{
    static void Main()
    {
        string filePath = "C:\\Users\\Jayanth C\\Documents\\C#Tutorial\\Class.txt";

        try
        {
            // Read the file contents
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {

                using (StreamReader reader = new StreamReader(file))
                {
                    // Read the entire file and display its content
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine(fileContent);
                }
                
            }        

            Console.WriteLine("File processing completed successfully!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please provide a valid file path.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Unauthorized access! You don't have permission to   create the file.");
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while processing the file: " + ex);
        }
        finally
        {
            
        }

        Console.ReadLine();
    }

}