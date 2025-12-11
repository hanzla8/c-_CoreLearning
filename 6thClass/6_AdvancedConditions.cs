using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._6thClass
{
    internal class _6_AdvancedConditions
    {
        static void Main(string[] args) 
        {
            // User input (easy start)
            Console.WriteLine("Apna grade batao (A, B, C):");
            string gradeInput = Console.ReadLine().ToUpper();  // Upper banao taake case ignore
            Console.WriteLine(" YOU ENTERED GRADE: " + gradeInput);
            char grade = gradeInput[0];  // Pehla char lo (jaise "A" se 'A')

            Console.WriteLine("Apni age batao:");
            int age = int.Parse(Console.ReadLine());  // Note: Real mein try-catch add
            Console.WriteLine(age + " Is your Age.");

            // Nested If with logical operators (in-depth example)
            if (age >= 18)  // Outer condition
            {
                Console.WriteLine("Adult check passed.");
                if (grade == 'A' || grade == 'B')  // Inner: OR use
                {
                    Console.WriteLine("Good grade for adult!");
                }
                else
                {
                    Console.WriteLine("Improve grade.");
                }
            }
            else
            {
                Console.WriteLine("You are minor.");
            }

            // Switch statement (easy menu style)
            switch (grade)
            {
                case 'A':  // Match 'A'
                    Console.WriteLine("A: Excellent! ⭐");
                    break;  // Stop here
                case 'B':
                    Console.WriteLine("B: Good job! 👍");
                    break;
                case 'C':
                    Console.WriteLine("C: Okay, try harder.");
                    break;
                default:  // Koi match na ho
                    Console.WriteLine("Invalid grade! 😕");
                    break;
            }

            // Ternary operator (short decision)
            string adultStatus = (age >= 18) ? "Adult ho, responsibility lo." : "Kid ho, maze karo.";
            Console.WriteLine(adultStatus);

            Console.ReadLine();  // Wait for output
        }
    }
}
