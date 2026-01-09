using System;

class Program
{
    static void Main(string[] args)
    {
        int guessCount = 1;
        Random randomGenerator = new Random();
        int luckyNumber = randomGenerator.Next(1,101);

        Console.WriteLine("Welcome the the Number guessing game!");
        string userGuess = "";
        string playGame = "";
        

        while (playGame != "no")
        {
            Console.WriteLine("What is your guess?");
            userGuess = Console.ReadLine();

            // int luckyNumParse = int.Parse(luckyNumber);
            int userGuessParse = int.Parse(userGuess);

            if (userGuessParse > luckyNumber)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("");
            }
            else if (userGuessParse < luckyNumber)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You guessed the lucky number!");
                Console.WriteLine("");
                Console.WriteLine($"You guessed {guessCount} times.");
                Console.WriteLine("Do you want to play again? (yes/no)");
                playGame = Console.ReadLine();
                if (playGame == "yes")
                {
                    guessCount = 0;
                    luckyNumber = randomGenerator.Next(1,101);
                }
            }
            guessCount++;
        }
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("");
    }
}