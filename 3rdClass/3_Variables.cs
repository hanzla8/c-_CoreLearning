using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._2ndClass
{
    internal class _3_Variables
    {
        static void Main(string[] args)
        {
            // Variable declaration aur assignment
            int age = 25;  // Integer type
            double height = 5.9;  // Decimal type
            string name = "Hanzala";  // Text type
            bool isAdult = true;  // Boolean type
            char initial = 'A';  // Single char

            // Print karo
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is Adult: " + isAdult);
            Console.WriteLine("Initial: " + initial);

            // Type conversion example
            double num = 10.5;
            int intNum = (int)num;  // Explicit cast: 10.5 se 10
            Console.WriteLine("Converted: " + intNum);

            // User input aur parse
            Console.WriteLine("Enter your age:");
            string input = Console.ReadLine();
            int userAge = int.Parse(input);  // String to int
            Console.WriteLine("Your age: " + userAge);

            Console.ReadLine();  // Wait for input

        }
    }
}
