using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("This program converts numerical grades to letter grades.");
            Console.WriteLine();

            try
            {
                // Prompt user for numerical grade
                Console.Write("Enter a numerical grade (0-100): ");
                string input = Console.ReadLine();

                // Parse the input to double
                if (double.TryParse(input, out double grade))
                {
                    // Validate grade range
                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Error: Grade must be between 0 and 100.");
                        return;
                    }

                    // Determine letter grade
                    string letterGrade = GetLetterGrade(grade);
                    
                    // Display result
                    Console.WriteLine($"Numerical Grade: {grade}");
                    Console.WriteLine($"Letter Grade: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid numerical grade.");
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
        /// Converts numerical grade to letter grade based on standard grading scale
        /// </summary>
        /// <param name="grade">Numerical grade between 0 and 100</param>
        /// <returns>Letter grade (A, B, C, D, or F)</returns>
        static string GetLetterGrade(double grade)
        {
            if (grade >= 90)
                return "A";
            else if (grade >= 80)
                return "B";
            else if (grade >= 70)
                return "C";
            else if (grade >= 60)
                return "D";
            else
                return "F";
        }
    }
}
