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

            while (option == false)
            { Console.Write("Enter Choice: ");
                int userInput = int.Parse(Console.ReadLine());
				if (userInput == 1)
                {
					if (currentNumber == 3) { Console.WriteLine("Step 3 is restricted and was skipped.\n"); stepNumber++; currentNumber++; continue; }
					if (currentNumber == 5) { Console.WriteLine("Safety limit reach. Routine stopped.\n"); continue; }
					Console.WriteLine($"Routine {currentNumber} complete.\n"); stepNumber++; currentNumber++;}
                else if (userInput == 2)
                { Console.WriteLine($"Current progress: {stepNumber} steps completed.\n"); }
                else if (userInput == 3)
                { Console.WriteLine("Program ended."); option = true; }

            }
        }
    }
}
