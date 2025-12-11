using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._7thClass
{
    internal class _7_Loops
    {
        static void Main(string[] args) 
        {
            // For Loop: 1 se 10 tak sum (intern calc example)
            int sum = 0;
            for (int i = 1; i <= 10; i++)  // Init i=1, i<=10, i++
            {
                sum += i;  // sum = sum + i
                if (i == 5) continue;  // 5 skip (demo)
                Console.WriteLine("Number: " + i);
            }
            Console.WriteLine("Total Sum (with skip): " + sum);  // Output: 55 (skip nahi asar sum pe)




            // While Loop: User positive numbers add jab tak negative na daale
            int total = 0;
            Console.WriteLine("Positive numbers daalo, negative to stop:");
            int num = int.Parse(Console.ReadLine());  // Pehla input
            while (num >= 0)  // Jab tak positive
            {
                total += num;
                Console.WriteLine("Enter next:");
                num = int.Parse(Console.ReadLine());  // Update
            }
            Console.WriteLine("Total: " + total);





            // Do-While: Menu example (at least once show)
            string choice;
            do
            {
                Console.WriteLine("Menu: 1. Add 2. Exit");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Added!");
                }
                else if (choice == "2")
                {
                    break;  // Exit loop
                }
                else
                {
                    Console.WriteLine("Invalid, try again.");
                }
            } while (choice != "2");  // Jab tak 2 na ho






            // Nested For: Table print (intern report style)
            Console.WriteLine("Multiplication Table:");
            for (int row = 1; row <= 3; row++)  // Outer: Rows
            {
                for (int col = 1; col <= 3; col++)  // Inner: Columns
                {
                    Console.Write(row * col + "\t");  // Tab space
                }
                Console.WriteLine();  // New line
            }






            Console.Write("Koi bhi character likho (*, #, @): ");
            char symbol = Console.ReadKey().KeyChar;  // User ka character

            Console.WriteLine(); // new line

            for (int h = 1; h <= 10; h++)
            {
                for (int j = 1; j <= h; j++)
                {
                    Console.Write(symbol);   // user ka symbol print hoga
                }
                Console.WriteLine();  // next line
            }

            Console.ReadLine();  // Wait

        }
    }
}
