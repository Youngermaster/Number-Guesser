using System;


namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            // START HERE //

            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Init correct number.
                int correctNumber;

                // Create a new random object.
                Random random = new Random();

                correctNumber = random.Next(1, 10);

                // Init guess var,
                int guessNumber = 0;

                PrintColorMessage(ConsoleColor.Blue, "Guess a number between 1 and 10");
                // While guess is not correct
                while (guessNumber != correctNumber)
                {
                    // Get users input.
                    string userInput = Console.ReadLine();

                    // Make sure is a number.
                    if (!int.TryParse(userInput, out guessNumber))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Enter a number between 1 and 10.");

                        // Kepp going.
                        continue;
                    }

                    // Cast to int and put in guess number.
                    guessNumber = Int32.Parse(userInput);

                    // Match guess to correct number.
                    if (guessNumber != correctNumber)
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                      
                    
                }

                PrintColorMessage(ConsoleColor.Yellow, "Congragulations! You are CORRECT.");

                // Ask user to play again.
                Console.WriteLine("Play again? [Y or N]");

                // Get answer.
                string userAnswer = Console.ReadLine().ToUpper();

                if (userAnswer == "Y")
                    continue;
                else
                {
                    PrintColorMessage(ConsoleColor.Blue, "Bye");
                    
                    return;
                }
            }
        }

        // Get and display info.
        static void GetAppInfo()
        {
            // Set app vars.
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Juan Manuel Young Hoyos";

            // Change text color.
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info.
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color.
            Console.ResetColor();
        }

        // Ask user name and greet.
        static void GreetUser()
        {
            // Ask users name.
            Console.WriteLine("What is your name?");

            // Get user input.
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", userName);
        }

        // Print color message.
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color.
            Console.ForegroundColor = color;

            // Ask user for a number.
            Console.WriteLine(message);

            // Reset text color.
            Console.ResetColor();
        }
    }
}