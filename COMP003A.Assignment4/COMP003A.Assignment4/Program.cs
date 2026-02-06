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
                { Console.WriteLine($"Routine {currentNumber} complete.\n"); stepNumber++; currentNumber++; }
                if (userInput == 2) 
				{ Console.WriteLine($"Current progress: {stepNumber} steps completed.\n"); }
                if (userInput == 3) 
				{ Console.WriteLine("Program ended."); option = true; }
               
			}









        }
    }
}
