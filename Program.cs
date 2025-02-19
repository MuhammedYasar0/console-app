// This is the main namespace for our console application
namespace ConsoleApp
{
    // This class contains a method that performs mathematical operations and displays values
    public class MathOperations
    {
        // This method takes two integers as parameters
        // It multiplies the first number by 2 and displays the second number
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // Perform math operation on the first number
            int result = firstNumber * 2;
            
            // Display the results
            Console.WriteLine($"First number after operation (multiplied by 2): {result}");
            Console.WriteLine($"Second number: {secondNumber}");
        }
    }

    // This is the main class of our program
    public class Program
    {
        // This is the entry point of our application
        public static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the method with positional parameters
            Console.WriteLine("Calling method with positional parameters:");
            math.ProcessNumbers(5, 10);

            // Call the method with named parameters
            Console.WriteLine("\nCalling method with named parameters:");
            math.ProcessNumbers(firstNumber: 7, secondNumber: 14);

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
} 