using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Movie Theater Ticket Price Calculator ===");
            Console.WriteLine("Regular price: GHC10");
            Console.WriteLine("Discounted price (Children ≤12 or Seniors ≥65): GHC7");
            Console.WriteLine();

            try
            {
                // Prompt user for age
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                // Parse the input to integer
                if (int.TryParse(input, out int age))
                {
                    // Validate age
                    if (age < 0)
                    {
                        Console.WriteLine("Error: Age cannot be negative.");
                        return;
                    }

                    // Calculate ticket price
                    decimal ticketPrice = CalculateTicketPrice(age);
                    string discountInfo = GetDiscountInfo(age);
                    
                    // Display result
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Category: {discountInfo}");
                    Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
                }
                else
                {
                    Console.WriteLine("Error: Please enter a valid age.");
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
        /// Calculates ticket price based on age
        /// </summary>
        /// <param name="age">Customer's age</param>
        /// <returns>Ticket price in GHC</returns>
        static decimal CalculateTicketPrice(int age)
        {
            const decimal regularPrice = 10.00m;
            const decimal discountedPrice = 7.00m;

            // Children (12 and below) or Senior citizens (65 and above) get discount
            if (age <= 12 || age >= 65)
                return discountedPrice;
            else
                return regularPrice;
        }

        /// <summary>
        /// Gets discount category information for display
        /// </summary>
        /// <param name="age">Customer's age</param>
        /// <returns>Category description</returns>
        static string GetDiscountInfo(int age)
        {
            if (age <= 12)
                return "Child (12 and below) - Discounted";
            else if (age >= 65)
                return "Senior Citizen (65 and above) - Discounted";
            else
                return "Regular Customer";
        }
    }
}
