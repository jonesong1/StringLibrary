using System;
using System.Linq;

namespace ShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;

            do
            {
                if (row == 0 || row >= 25)
                    ResetConsole();

                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                Console.WriteLine($"Input: {input}");
                Console.WriteLine("Begins with uppercase? " +
                     $"{(StartsWithUpper(input) ? "Yes" : "No")}");
                Console.WriteLine();
                row += 4;
            } while (true);
            return;

            // Declare a ResetConsole local method
            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
                row = 3;
            }
            
        }
        static bool StartsWithUpper(string word)
        {
            return Enumerable.Range(65, 26).Contains((int)word[0]);
        }
    }
}
