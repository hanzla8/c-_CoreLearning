using System;  // Console ke liye

namespace Class9_FunctionBasics  // Tumhare project mein adjust
{
    class Program
    {
        // Function 1: Void type, no return, parameters ke saath (easy greet)
        public static void GreetUser(string name)  // Static taake Main se call ho
        {
            Console.WriteLine("Hello, " + name + "! Welcome to C#.");
        }

        // Function 2: Return type int, parameters, calculation (in-depth add)
        public static int AddNumbers(int a, int b)  // Input a aur b
        {
            int result = a + b;  // Process
            return result;  // Output return
        }

        static void Main(string[] args)
        {
            // User input
            Console.WriteLine(" Apna naam batao:");
            string userName = Console.ReadLine();

            // Function call 1: Greet
            GreetUser( userName);  // Call with arg

            // Function call 2: Add
            Console.WriteLine(" Do numbers batao add ke liye:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int sum = AddNumbers(num1, num2);  // Call aur return lo
            Console.WriteLine(" Sum: " + sum);

            // Advanced demo: Function khud call another
            int total = AddNumbers(sum, 10);  // Reuse
            Console.WriteLine(" Total with +10: " + total);

            Console.ReadLine();  // Wait
        }
    }
}