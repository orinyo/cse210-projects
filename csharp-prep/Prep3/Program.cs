using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes"; // Variable to track if user wants to play again

        // Loop to keep playing the game until the user says no
        while (playAgain == "yes")
        {
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Random number from 1 to 100

            int guess = -1; // Initialize guess to an invalid value to enter the loop
            int guessCount = 0; // Counter to keep track of guesses

            // Keep looping until the user guesses the correct number
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                string inputGuess = Console.ReadLine();
                guess = int.Parse(inputGuess);

                // Increment the guess counter
                guessCount++;

                // Compare the guess to the magic number and give feedback
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}