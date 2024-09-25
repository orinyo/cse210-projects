using System;

class Program
{
    static void Main()
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();
        int userInput;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Get user input and add numbers to the list until 0 is entered
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        while (userInput != 0);

        // Check if the list has any numbers
        if (numbers.Count > 0)
        {
            // Core Requirements
            // Compute the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Compute the average
            float average = (float)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the maximum
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is: {max}");

            // Stretch Challenges
            // Find the smallest positive number
            int? smallestPositive = null;
            foreach (int number in numbers)
            {
                if (number > 0 && (smallestPositive == null || number < smallestPositive))
                {
                    smallestPositive = number;
                }
            }
            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the list and display the sorted list
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}