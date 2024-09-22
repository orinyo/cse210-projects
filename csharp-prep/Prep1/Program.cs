using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Output the name in the format: last-name, first-name, last-name
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}