using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); //run getappinfo function to get info

            GreetUser(); //ask for user's name and greet

            while (true)
            {

                //int correctNumber = 7;

                //create random object
                Random random = new Random();

                //init correct number

                int correctNumber = random.Next(1, 10);

                // init guess var 
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();


                    //make sure it's a number

                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //keep going 
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //output success message

                PrintColorMessage(ConsoleColor.Yellow, "correct u guessed it");

                //ask to play again
                Console.WriteLine("play again? [Y or N]");

                //get answer

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // get and display app infor
        static void GetAppInfo()
        {
            //set app vars

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Dimitar";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //ask user's name and greet
        static void GreetUser()
        {
            //ask user's name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;


            // tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
