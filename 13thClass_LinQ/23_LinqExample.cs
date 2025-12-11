using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._12thClass_LinQ
{
    internal class _23_LinqExample
    {
        static void Main(string[] args)
        {
            // Data source banao - ek simple int array (LINQ ispe query karega)
            int[] numbers = { 5, 2, 8, 3, 1, 7, 4, 6 };  // Ye list hai jisko hum query karenge

            // Step 1: Where - Filter karo (condition pe items select)
            // Explanation: Where condition check karta hai, true wale items return. Jaise even numbers filter.
            var evenNumbers = numbers.Where(n => n % 2 == 0);  // Lambda expression: n even ho to true
            Console.WriteLine("Where (Even numbers): " + string.Join(", ", evenNumbers));  // Output: 2, 8, 4, 6

            // Step 2: Select - Transform karo (har item ko change kar ke new list banao)
            // Explanation: Select har item pe operation lagata hai, new projection return. Jaise double karo.
            var doubled = numbers.Select(n => n * 2);  // Har number double
            Console.WriteLine("Select (Doubled): " + string.Join(", ", doubled));  // Output: 10, 4, 16, 6, 2, 14, 8, 12

            // Step 3: OrderBy - Ascending sort (chhoti se badi)
            // Explanation: OrderBy items ko sort karta hai key pe (jaise number). Stable sort.
            var sortedAsc = numbers.OrderBy(n => n);  // Number khud key hai
            Console.WriteLine("OrderBy (Ascending): " + string.Join(", ", sortedAsc));  // Output: 1, 2, 3, 4, 5, 6, 7, 8

            // Step 4: OrderByDescending - Descending sort (badi se chhoti)
            // Explanation: OrderByDescending reverse sort. ThenBy se multiple sort (advanced).
            var sortedDesc = numbers.OrderByDescending(n => n);  // Descending
            Console.WriteLine("OrderByDescending (Descending): " + string.Join(", ", sortedDesc));  // Output: 8, 7, 6, 5, 4, 3, 2, 1

            // Step 5: First / FirstOrDefault - Pehla item lo
            // Explanation: First pehla matching return, agar nahi to exception. FirstOrDefault default return (int ke liye 0).
            var firstEven = numbers.First(n => n % 2 == 0);  // Pehla even
            Console.WriteLine("First (Pehla even): " + firstEven);  // Output: 2 (agar even na ho to error)

            var firstOddGreater10 = numbers.FirstOrDefault(n => n > 10 && n % 2 != 0);  // Nahi mile to 0
            Console.WriteLine("FirstOrDefault (Odd >10, nahi mila): " + firstOddGreater10);  // Output: 0

            // Step 6: Any - Check karo koi item condition match karta hai ya nahi (bool return)
            // Explanation: Any loop bina poora kiye stop agar match mile. Fast for exists check.
            bool hasEven = numbers.Any(n => n % 2 == 0);  // Koi even hai?
            Console.WriteLine("Any (Koi even hai?): " + hasEven);  // Output: True

            // Step 7: Count - Items count karo
            // Explanation: Count total ya condition pe items ginata hai. Long return for big data.
            int totalCount = numbers.Count();  // Poora count
            Console.WriteLine("Count (Total items): " + totalCount);  // Output: 8

            int evenCount = numbers.Count(n => n % 2 == 0);  // Condition pe
            Console.WriteLine("Count (Even items): " + evenCount);  // Output: 4

            // Step 8: Distinct - Unique items lo (duplicates remove)
            // Explanation: Distinct hash set use karta hai uniques ke liye. Custom comparer possible.
            int[] withDuplicates = { 1, 2, 2, 3, 3, 4 };  // Duplicates wala array
            var unique = withDuplicates.Distinct();  // Uniques
            Console.WriteLine("Distinct (Uniques): " + string.Join(", ", unique));  // Output: 1, 2, 3, 4

            // Advanced Chain: Sab methods combine (LINQ ki power)
            // Explanation: LINQ chainable hai - ek query mein bohot operations.
            var chained = numbers.Where(n => n > 3)  // Filter >3
                                 .OrderByDescending(n => n)  // Desc sort
                                 .Select(n => n * 10);  // 10 times
            Console.WriteLine("Chained (Filter >3, Desc sort, *10): " + string.Join(", ", chained));  // Output: 80, 70, 60, 50, 40

            Console.ReadLine();  // Wait taake output dekho

        }
    }
}
