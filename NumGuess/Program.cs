﻿using System;

// Namspace
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo function to get info
            GetAppInfo();

            // Ask for Users name and greet
            GreetUser();

            while (true)
            {

                // Init correct number
                // int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number...");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again...");

                    }


                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!! You guessed it!");

                while (true)
                {
                    // Ask to play again
                    Console.WriteLine("Play Again? [Y or N]");

                    // Get answer
                    string answer = Console.ReadLine().ToUpper();


                    if (answer == "Y")
                    {
                        break;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        // Print success message
                        PrintColorMessage(ConsoleColor.Cyan, "Incorrect answer, Please answer Yes or No...");
                        continue;
                    }
                }

            }

        }

        // Get and display app info
        static void GetAppInfo()
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
        }

        // Ask users name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();


            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
