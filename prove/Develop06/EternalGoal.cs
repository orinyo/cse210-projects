using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded event for {Name}. You earned {Points} points!");
    }

    public override string GetProgress()
    {
        return "[∞]"; // Symbolizes endless progress
    }

    public override string SaveData()
    {
        return $"EternalGoal;{Name};{Description};{Points}";
    }
}