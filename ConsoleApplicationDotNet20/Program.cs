using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationDotNet20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            // Convert input strings to numbers
            int num1, num2;
            if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {
                // Calculate and print the sum
                int sum = num1 + num2;
                Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid integer numbers.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
