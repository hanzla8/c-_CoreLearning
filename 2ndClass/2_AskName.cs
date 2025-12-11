namespace c__practiceCode._2ndClass
{
    internal class _2_AskName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");

            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();  // Pehle string mein lo
            try
            {
                int userAge = int.Parse(ageInput);  // Ab int mein convert karo
                Console.WriteLine("Your age is " + userAge + "!");
            }
            catch (Exception)
            {
                Console.WriteLine("Galat input! Age sirf number honi chahiye, jaise 25.");
            }
            Console.ReadLine();  // Ye last mein add karo taake console band na ho jaldi
        }
    }
}
