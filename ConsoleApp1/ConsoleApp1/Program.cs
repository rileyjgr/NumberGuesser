using System;


// Namespace
namespace ConsoleApp1
{
    //Main class
    class Program
    {
        // Entry Point
        // void = return 
        // static = the function itself
        static void Main(string[] args)
        {

            GetAppInfo();

            GreatUser();

            while (true)
            {

                // init correct number
                // create new random object

                Random correctNumberObject = new Random();

                int correctNumber = correctNumberObject.Next(1, 10);

                // init guess var 

                int guess = 0;

                // ask user for number
                Console.WriteLine("Guess a Number between 1 and 10");

                //white guess is not correct
                while (guess != correctNumber)
                {

                    //Get users input
                    String userGuess = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(userGuess, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "Please enter a real number");

                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess

                    guess = Int32.Parse(userGuess);

                    //Math guess to correct number

                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "WRONG!");
                    }

                }

                // Output win
                PrintColor(ConsoleColor.Yellow, "Noice.");

                // Ask to play again

                PrintColor(ConsoleColor.Green, "Do You want to play again? [Y/N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Riley";

            // Change text color

            Console.ForegroundColor = ConsoleColor.Blue;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();
        }

        static void GreatUser()
        {
            // Ask users name
            Console.WriteLine("What is your name ?");

            // Get user input 
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }

        static void PrintColor(ConsoleColor color, string message)
        {
            // NaN
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
