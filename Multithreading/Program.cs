using System;
using System.Threading;
using System.Threading.Tasks;

class MultithreadingApp
{
    static void Main()
    {
        try
        {
            // Create a task for background processing
            Task backgroundTask = Task.Run(() =>
            {
                // Simulate some work
                Thread.Sleep(2000);

                // Throw an exception
                throw new InvalidOperationException("Something went wrong in the background task.");
            });

            // Continue with other operations in the main thread
            Console.WriteLine("Main thread continues executing...");

            // Wait for the background task to complete
            backgroundTask.Wait();
        }
        catch (AggregateException ex)
        {
            // Handle the exception(s) thrown in the background task
            foreach (var innerException in ex.InnerExceptions)
            {
                Console.WriteLine("An exception occurred: " + innerException.Message);
                // Additional error handling or logging can be performed here
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        Console.WriteLine("Application completed.");
        Console.ReadLine();
    }
}


