using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Ultimate Guess My Number Game!\n");
        Console.WriteLine("==============================================");
        Console.WriteLine("  Features:");
        Console.WriteLine("  - Type 'quit' anytime to exit");
        Console.WriteLine("  - Random number generation (1-100)");
        Console.WriteLine("  - Guess tracking and statistics");
        Console.WriteLine("  - Play multiple rounds");
        Console.WriteLine("  - Input validation");
        Console.WriteLine("==============================================\n");

        Random randomGenerator = new Random();
        bool keepPlaying = true;
        int totalGames = 0;
        int totalGuesses = 0;
        int bestGame = int.MaxValue;

        while (keepPlaying)
        {
            totalGames++;
            int magicNumber = randomGenerator.Next(1, 101);
            int guessCount = 0;
            bool gameCompleted = false;

            Console.WriteLine($"\nGame #{totalGames} - I'm thinking of a number between 1-100.");
            Console.WriteLine("Type 'quit' at any time to exit.\n");

            string input = "";

            while (!gameCompleted)
            {
                Console.Write("What is your guess? ");
                
                input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    Console.WriteLine("\nExiting current game...");
                    totalGames--;
                    gameCompleted = true;
                    continue;
                }

                if (!int.TryParse(input, out int guess) || guess < 1 || guess > 100)
                {
                    Console.WriteLine("Please enter a number (1-100) or 'quit' to exit.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"\n You guessed it in {guessCount} tries! ");
                    totalGuesses += guessCount;
                    bestGame = Math.Min(bestGame, guessCount);
                    gameCompleted = true;
                }
            }

            if (gameCompleted && input != "quit")
            {
                Console.WriteLine("\nGame Statistics:");
                Console.WriteLine($"- Guesses this game: {guessCount}");
                Console.WriteLine($"- Best game: {(bestGame == int.MaxValue ? "N/A" : bestGame.ToString())}");
                Console.WriteLine($"- Average guesses: {(totalGames > 0 ? (double)totalGuesses / totalGames : 0):F1}");

                string response;
                do
                {
                    Console.Write("\nPlay again? (yes/no/quit) ");
                    response = Console.ReadLine().ToLower();

                    if (response == "quit")
                    {
                        keepPlaying = false;
                        break;
                    }

                } while (response != "yes" && response != "no");

                keepPlaying = (response == "yes");
            }
            else
            {
                Console.Write("\nExit the program completely? (yes/no) ");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    keepPlaying = false;
                }
            }
        }

        if (totalGames > 0)
        {
            Console.WriteLine("\n==============================================");
            Console.WriteLine("  Final Statistics:");
            Console.WriteLine($"  - Games completed: {totalGames}");
            Console.WriteLine($"  - Total guesses: {totalGuesses}");
            Console.WriteLine($"  - Best game: {bestGame} guesses");
            Console.WriteLine($"  - Average guesses: {((double)totalGuesses / totalGames):F1}");
            Console.WriteLine("==============================================");
        }

        Console.WriteLine("\nThanks for playing! Goodbye!\n");
    }
}
