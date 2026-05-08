using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting requirement
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight exceeds the 50lb limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Ends the program if weight is too high
                return;
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Calculate total dimensions to check against size limit
            float dimensionsTotal = width + height + length;

            // Check if combined dimensions exceed the 50 limit
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Ends the program if dimensions are too large
                return;
            }

            // Calculate the shipping quote:
            // Multiply dimensions together (volume), multiply by weight, then divide by 100.
            float quote = (width * height * length * weight) / 100;

            // Display the final quote formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open
            Console.ReadLine();
        }
    }
}
