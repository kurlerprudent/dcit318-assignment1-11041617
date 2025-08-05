using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine("This program identifies the type of triangle based on the lengths of its three sides.");
            Console.WriteLine();

            try
            {
                // Get three sides from user
                double side1 = GetSideLength("first");
                double side2 = GetSideLength("second");
                double side3 = GetSideLength("third");

                // Validate if the sides can form a triangle
                if (IsValidTriangle(side1, side2, side3))
                {
                    // Determine triangle type
                    string triangleType = DetermineTriangleType(side1, side2, side3);
                    
                    // Display results
                    Console.WriteLine("\n=== Results ===");
                    Console.WriteLine($"Side 1: {side1}");
                    Console.WriteLine($"Side 2: {side2}");
                    Console.WriteLine($"Side 3: {side3}");
                    Console.WriteLine($"Triangle Type: {triangleType}");
                }
                else
                {
                    Console.WriteLine("\nError: The given sides cannot form a valid triangle.");
                    Console.WriteLine("Note: The sum of any two sides must be greater than the third side.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompts user to enter a side length and validates the input
        /// </summary>
        /// <param name="position">Position of the side (first, second, third)</param>
        /// <returns>Valid side length</returns>
        static double GetSideLength(string position)
        {
            while (true)
            {
                Console.Write($"Enter the length of the {position} side: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Error: Please enter a positive number for the side length.");
                }
            }
        }

        /// <summary>
        /// Checks if three sides can form a valid triangle using triangle inequality theorem
        /// </summary>
        /// <param name="side1">First side length</param>
        /// <param name="side2">Second side length</param>
        /// <param name="side3">Third side length</param>
        /// <returns>True if sides can form a triangle, false otherwise</returns>
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            // Triangle inequality theorem: sum of any two sides must be greater than the third side
            return (side1 + side2 > side3) && 
                   (side1 + side3 > side2) && 
                   (side2 + side3 > side1);
        }

        /// <summary>
        /// Determines the type of triangle based on side lengths
        /// </summary>
        /// <param name="side1">First side length</param>
        /// <param name="side2">Second side length</param>
        /// <param name="side3">Third side length</param>
        /// <returns>Triangle type (Equilateral, Isosceles, or Scalene)</returns>
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            // Use small epsilon for floating point comparison
            const double epsilon = 1e-10;

            // Check if all sides are equal (Equilateral)
            if (Math.Abs(side1 - side2) < epsilon && 
                Math.Abs(side2 - side3) < epsilon && 
                Math.Abs(side1 - side3) < epsilon)
            {
                return "Equilateral (All three sides are equal)";
            }
            // Check if any two sides are equal (Isosceles)
            else if (Math.Abs(side1 - side2) < epsilon || 
                     Math.Abs(side2 - side3) < epsilon || 
                     Math.Abs(side1 - side3) < epsilon)
            {
                return "Isosceles (Two sides are equal)";
            }
            // All sides are different (Scalene)
            else
            {
                return "Scalene (No sides are equal)";
            }
        }
    }
}
