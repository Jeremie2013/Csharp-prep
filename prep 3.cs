using System;

class Program
{
    static void Main()
    {
        // Core Requirement 1: Ask the user for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = Convert.ToInt32(Console.ReadLine());

        // Core Requirement 2: Add a loop that continues until the user guesses correctly
        int guess;
        do
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());

            // Using an if statement, determine if the user needs to guess higher or lower
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
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

        // Stretch Challenge: Keep track of the number of guesses
        int guessCount = 1; // Initialize with 1 as the first guess is already taken

        // Core Requirement 3: Ask if the user wants to play again and loop accordingly
        Console.Write("Do you want to play again? (yes/no): ");
        string playAgain = Console.ReadLine().ToLower();

        while (playAgain == "yes")
        {
            // Generate a new random magic number
            magicNumber = new Random().Next(1, 101);

            do
            {
                // Ask the user for a guess
                Console.Write("What is your guess? ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                // Using an if statement, determine if the user needs to guess higher or lower
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
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            } while (guess != magicNumber);

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
            guessCount = 1; // Reset guess count for the new game
        }
    }
}
