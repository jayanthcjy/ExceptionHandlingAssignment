using System;

class InputValidationApp
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a numeric value: ");
            string userInput = Console.ReadLine();

            // Convert the user input to a numeric value
            int numericValue = Convert.ToInt32(userInput);


            Console.WriteLine("Input validation successful!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input! The value entered is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.ReadLine();
    }
}
