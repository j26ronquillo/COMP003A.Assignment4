using System.ComponentModel.Design;
using System.Diagnostics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Start/Continue Routine\n2. View Progress\n3. Exit\n");

            bool option = false;
            int currentNumber = 1;
            int stepNumber = 0;
            /* Loops exist because it helps the programmer help with continuous displays instead of them having to copy mutliple blocks.
             It also executes a block of code repeatly until a specific condition is met.*/
            while (option == false) 
            {
                Console.Write("Enter Choice: ");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 1)
                {
                    if (currentNumber == 3) { Console.WriteLine("Step 3 is restricted and was skipped.\n"); stepNumber++; currentNumber++; continue; }
                    if (currentNumber == 5) { Console.WriteLine("Safety limit reach. Routine stopped.\n"); continue; }
                    Console.WriteLine($"Routine {currentNumber} complete.\n"); stepNumber++; currentNumber++;
                }

                else if (userInput == 2)
                { Console.WriteLine($"Current progress: {stepNumber} steps completed.\n"); }

                else if (userInput == 3)
                { Console.WriteLine("Program ended."); break; }
             /* Loops skip steps or blocks because of control flow statements like using continue or break. If the condition for the value is not true to begin with,
              * the program would never start. Managing control flow in loop statements must be watched carefully as it can accidently lead to infinite loops if not used.*/
            
            }
        }
    }
}
