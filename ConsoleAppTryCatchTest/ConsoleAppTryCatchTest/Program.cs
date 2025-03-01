using System;  // Import the System namespace for console operations.

namespace TryCatchTest
{

    // This Program demonstrates exception handling in C#.

    class Program
    {

        // The Main method is the entry point of the application.
        // The Main method prompts the user to enter their age, attempts to convert it to an integer,
        // and demonstrates exception handling with try, catch, and finally blocks.

        static void Main(string[] args)
        {

            // The try block contains code that may throw an exception.
            // If text is used, it will throw an exception. 
            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());  // Read input from the console and attempt to convert it to an integer.
                Console.WriteLine("Your age is: " + age);   // Display the entered age.

                //throw new ArithmeticException("ArithmeticException error!");  // To manually throw an ArithmeticException (to demonstrate exception handling).

            }
            // The catch block handles exceptions that occur in the try block.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   // Display the error message associated with the exception.

            }
            // The finally block always executes, regardless of whether an exception was thrown or not.
            finally
            {
                
                Console.WriteLine("\nThe 'try catch' is finished.");

            }

        }
    }
}
