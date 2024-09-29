using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            List<string> prompts = new List<string>
            {
                "Did anything occur today that caught you off guard or surprised you? ",
                "What was the toughest challenge you encountered today and how did you handle it? ",
                "What was the highlight of your day and what made it special? ",
                "Who did you connect with in a meaningful way today? ",
                "Did you come across any new ideas or learn something fascinating today? ",
                "Did anyone brighten your day or show you kindness today? ",
                "Were you able to accomplish something noteworthy in your work, studies, or personal pursuits today? ",
                "Did you push yourself beyond your usual boundaries today? ",
                "What area of your daily routine would you like to improve, and what steps will you take to do so? ",
                "What is your biggest hope or goal for tomorrow? ",
                "How did you express love or compassion for others today, inspired by your beliefs? ",
                "Were there any unexpected blessings today that you feel were linked to your faith? If so, how would you describe them? ",
                "What was the most uplifting thing you read or heard today that deepened your faith? ",
                "In what moments did you feel a sense of divine guidance or presence today? ",
                "What was the most spiritually significant moment for you today? ",
                "How did you live out your faith today through your decisions or actions? "
            };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("See You Again, keep writing!");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}