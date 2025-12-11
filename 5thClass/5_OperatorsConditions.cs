using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._5thClass
{
    internal class _5_OperatorsConditions
    {
        static void Main(string[] args) 
        {
            // User se input lo (operators use: + for concat)
            Console.WriteLine("Apni age batao:");
            string input = Console.ReadLine();
            int age;  // Variable declare

            // Safe parse with condition (operators: ==, > etc. baad mein)
            if (int.TryParse(input, out age))  // TryParse: Safe, error nahi throw, bool return
            {
                // Arithmetic aur comparison operators
                int doubleAge = age * 2;  // Multiply
                Console.WriteLine("Double age: " + doubleAge);  // + for string join

                // Conditions with logical operators
                if (age >= 18 && age < 60)  // AND: Dono true
                {
                    Console.WriteLine("Aap adult hain aur working age mein.");
                }
                else if (age < 18)  // Less than
                {
                    Console.WriteLine("Aap kid hain.");
                }
                else if (age >= 60 || age < 0)  // OR: Ek true (negative bhi catch)
                {
                    Console.WriteLine("Aap senior hain ya galat age dali.");
                }
                else
                {
                    Console.WriteLine("Kuch galat hua.");  // Default, kabhi na pahunche
                }

                // Ternary operator (short if-else, advanced but useful)
                string status = (age >= 18) ? "Adult" : "Minor";  // ? true : false
                Console.WriteLine("Status: " + status);

                // Modulus example: Even/odd check
                if (age % 2 == 0)  // Remainder 0 to even
                {
                    Console.WriteLine("Age even hai.");
                }
                else
                {
                    Console.WriteLine("Age odd hai.");
                }
            }
            else
            {
                Console.WriteLine("Galat input! Sirf number daalo.");  // Agar parse fail
            }

            Console.ReadLine();  // Wait for close
        }
    }
}
