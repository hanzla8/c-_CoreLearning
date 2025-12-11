using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._4thClass
{
    internal class _4_AdvancedVariables
    {
        static void Main(string[] args) 
        {
            // Nullable type
            int? optionalAge = null;
            if (optionalAge.HasValue)
            {
                Console.WriteLine("Age: " + optionalAge.Value);
            }
            else
            {
                Console.WriteLine("No age provided.");
            }

            // String operations
            string fullName = "Hanzala Baloch";
            Console.WriteLine("Upper: " + fullName.ToUpper());
            Console.WriteLine("Length: " + fullName.Length);
            Console.WriteLine("Substring: " + fullName.Substring(0, 6));  // "Hanzal"

            // Var keyword
            var score = 95.5;  // Double infer
            Console.WriteLine("Score: " + score);

            // Array variable
            string[] fruits = { "Apple", "Banana", "Orange" };
            Console.WriteLine("First fruit: " + fruits[0] + " SecondFruits :" + fruits[2]);  // Index 0 se start

            // Overflow check
            checked
            {
                try
                {
                    int max = int.MaxValue;  // 2147483647
                    int overflow = max + 1;  // Exception throw
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow error!");
                }
            }

            Console.ReadLine();


            //-----------------------------------------------------------------------------
            //---------------------------
        }
    }
}
