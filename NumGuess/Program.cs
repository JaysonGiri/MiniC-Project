using System;

// Namspace
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "SGP";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Write out app info 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();


            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if (guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user its the wrong number
                    Console.WriteLine("Wrong number, please try again...");

                    // Reset text color
                    Console.ResetColor();


                }


            }

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user its the right number
            Console.WriteLine("You are CORRECT!!!");

            // Reset text color
            Console.ResetColor();

        }
    }
}
