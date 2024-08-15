// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Theater!");
        Console.Write("Enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            // Apply promotions based on age
            decimal ticketPrice = 20.0m; // Default ticket price

            if (age < 18)
            {
                // Discount for individuals under 18
                ticketPrice -= 5.0m;
                Console.WriteLine("You qualify for a youth discount!");
            }
            else if (age >= 65)
            {
                // Discount for seniors aged 65 and above
                ticketPrice -= 8.0m;
                Console.WriteLine("You qualify for a senior discount!");
            }

            // Display the final ticket price
            Console.WriteLine($"Your ticket price is: ${ticketPrice}");

            // You can add more promotions based on different conditions as needed
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a valid age.");
        }

        Console.ReadLine(); // Keep the console window open
    }
}
