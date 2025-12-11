using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._8thClass
{
    internal class _8_Loops_aur_Arrays
    {
        static void Main(string[] args)
        {
            // Array declare aur init (intern data store)
            int[] numbers = { 5, 3, 8, 1, 9 };  // Size 5, initializer
            string[] names = new string[3];  // Empty, size 3
            names[0] = "Hanzla"; names[1] = "Faiza"; names[2] = "Baloch";

            // For Loop: Print aur sum (in-depth traverse)
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] == 8)  // Search demo
                {
                    Console.WriteLine("Found 8 at index " + i);
                    break;  // Early stop
                }
                Console.WriteLine("Number at " + i + ": " + numbers[i]);
            }
            Console.WriteLine("Total Sum: " + sum);

            // Foreach Loop: Simple read (names print)
            Console.WriteLine("Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());  // Operation per item
            }






            // While Loop: User fill array (dynamic feel)
            int[] userArray = new int[4];
            int index = 0;
            while (index < userArray.Length)
            {
                Console.WriteLine("Enter number " + (index + 1) + ":");
                userArray[index] = int.Parse(Console.ReadLine());
                index++;
            }
            Console.WriteLine("User Array: " + string.Join(", ", userArray));  // Join for print

            // Multi-Dimensional Array with Nested Loops
            int[,] matrix = { { 1, 2 }, { 3, 4 }, { 5, 6 } };  // 3 rows, 2 cols
            Console.WriteLine("Matrix:");
            for (int row = 0; row < matrix.GetLength(0); row++)  // GetLength(0) rows
            {
                for (int col = 0; col < matrix.GetLength(1); col++)  // GetLength(1) cols
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }




            // Advanced: Sort aur Search
            Array.Sort(numbers);  // Sort ascending
            Console.WriteLine("Sorted Numbers: " + string.Join(", ", numbers));
            int findIndex = Array.IndexOf(numbers, 5);  // Find 5
            Console.WriteLine("Index of 5: " + findIndex);

            Console.ReadLine();  // Wait
        }
    }
}
