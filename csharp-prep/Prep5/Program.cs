using System;

class Program
{
    static void Main()
    {
        // Call the DisplayWelcome function to display the welcome message
        DisplayWelcome();

        // Call PromptUserName to get the user's name
        string userName = PromptUserName();

        // Call PromptUserNumber to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Call SquareNumber to calculate the square of the favorite number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Call DisplayResult to show the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to calculate and return the square of a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}