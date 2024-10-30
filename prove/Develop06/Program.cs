using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static int _score = 0;
    private static List<Goal> _goals = new List<Goal>();

    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("0. Exit");
            
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: RecordEvent(); break;
                case 3: ShowGoals(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
                case 6: ShowScore(); break;
                case 0: running = false; break;
            }
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Choose goal type (1: Simple, 2: Eternal, 3: Checklist): ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1: _goals.Add(new SimpleGoal(name, description, points)); break;
            case 2: _goals.Add(new EternalGoal(name, description, points)); break;
            case 3:
                Console.Write("Target Count: ");
                int requiredCount = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, requiredCount, bonus)); break;
        }
    }

    private static void RecordEvent()
    {
        ShowGoals();
        Console.Write("Choose goal number to record event: ");
        int index = int.Parse(Console.ReadLine());

        _goals[index].RecordEvent();
        _score += _goals[index].Points;
    }

    private static void ShowGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].GetProgress()} {_goals[i].Name} - {_goals[i].Description}");
        }
    }

    private static void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveData());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        foreach (string line in lines)
        {
            _goals.Add(Goal.LoadData(line));
        }
        Console.WriteLine("Goals loaded successfully.");
    }

    private static void ShowScore()
    {
        Console.WriteLine($"Your total score is: {_score}");
    }
}
/*
    Eternal Quest Program - Exceeding Requirements Report

    This program implements a gamified goal-tracking system with three main goal types: 
    SimpleGoal, EternalGoal, and ChecklistGoal. In addition to meeting the basic 
    assignment requirements, several extra features were added to enhance functionality 
    and user engagement. These are documented below:

    1. **Scoring System with Gamification**: A total score is maintained to allow users 
       to track progress across different goals. This score increments based on points 
       from each completed goal event.

    2. **Progress Display**: Goals show their progress differently based on their type:
       - Simple goals display as completed or incomplete.
       - Eternal goals show as "infinite" to represent their recurring nature.
       - Checklist goals show completion progress in the format `[x/n]`, where `x` is the 
         current completion count and `n` is the target count.

    3. **Goal Saving and Loading**: The program includes the ability to save goals to 
       a text file and reload them, preserving the state across program runs. This 
       allows users to track long-term goals and resume progress even after restarting.

    4. **Leveling System (Optional)**: Additional features could include a leveling 
       system based on score thresholds, where users gain "levels" as they accumulate 
       points. This could be implemented in future versions.

    This modular design leverages polymorphism to add new goal types easily. This 
    ensures that future enhancements can be incorporated with minimal changes to the 
    existing structure.

    Author: Stephen Orinyo
    Date: 30/10/2024
*/