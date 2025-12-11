using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practiceCode._10_PractiseWhole
{
    internal class _10_PractiseWhole
    {
        static void Main(string[] args)
        {

            //1st Class Practise Problems
            Console.WriteLine("Apna naam batao:");  // Prompt
            string name = Console.ReadLine();  // Input lo
            Console.WriteLine("Hello, " + name + "!");  // Output with join



            //2nd Class Practise Problems
            int age = 25;  // Number store
            string name1 = "Ali";  // Text
            bool isAdult = true;  // True/false
            Console.WriteLine("Name: " + name1 + ", Age: " + age + ", Adult: " + isAdult);


            //7th class array and loop practise problems
            for (int i = 1; i <= 5; i++)  // Fixed repeat
            {
                Console.WriteLine(i);
            }

            int num = 0;
            while (num < 3)  // Unknown
            {
                Console.WriteLine("While: " + num);
                num++;
            }


            //8th class loop plus array practise problems
            int[] nums = { 1, 2, 3 };
            int sum = 0;
            foreach (int n in nums)  // Easy traverse
            {
                sum += n;
                Console.WriteLine(n);
            }
            Console.WriteLine("Sum: " + sum);



        }
    }
}
