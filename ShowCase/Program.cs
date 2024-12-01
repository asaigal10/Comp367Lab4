using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int lineCounter = 0;

        while (true)
        {
            if (lineCounter == 0 || lineCounter >= 20)
                ResetConsoleWindow();

            Console.Write("Enter a string (or press Enter to exit): ");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput)) break;

            bool isUppercase = userInput.StartsWithUpper();
            Console.WriteLine($"Your input: \"{userInput}\"");
            Console.WriteLine($"Does it start with an uppercase letter? {(isUppercase ? "Yes" : "No")}");
            Console.WriteLine(new string('-', 40));

            lineCounter += 4;
        }

        // Local method to reset the console
        void ResetConsoleWindow()
        {
            if (lineCounter > 0)
            {
                Console.WriteLine("Press any key to refresh...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("*** Uppercase Checker ***");
            Console.WriteLine("Type a string and press Enter to check.");
            Console.WriteLine("Press Enter on an empty line to exit.");
            Console.WriteLine(new string('-', 40));
            lineCounter = 4;
        }
    }
}
