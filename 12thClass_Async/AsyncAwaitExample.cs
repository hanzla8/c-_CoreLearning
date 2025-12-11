using System;
using System.Threading.Tasks;

namespace c__practiceCode._12thClass_Async
{
    internal class AsyncAwaitExample
    {
        // Main method - program ka starting point, async banaya taake await use ho sake
        static async Task Main(string[] args)
        {
            Console.WriteLine("Program start - Async demo.");

            // Async method call karo
            string result = await DownloadDataAsync();  // Await yahan wait karega bina block kiye

            Console.WriteLine("Result mila: " + result);
            Console.WriteLine("Program end - App responsive raha.");

            // Debug ke liye: Yahan breakpoint laga ke dekho (F9 in Visual Studio)
            Console.ReadLine();  // Wait taake console band na ho
        }

        // Async method - slow task simulate (jaise web download)
        static async Task<string> DownloadDataAsync()
        {
            Console.WriteLine("Downloading shuru... (simulate delay)");

            // Await Task.Delay - 2 seconds wait, real mein HttpClient use karo
            await Task.Delay(2000);  // Ye background mein chalega

            // Debug point: Yahan step into kar ke flow dekho
            return "Data downloaded successfully!";  // Result return
        }
    }
}