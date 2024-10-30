using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override void RecordEvent()
    {
        IsCompleted = true;
        Console.WriteLine($"{Name} goal completed! You earned {Points} points.");
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }

    public override string SaveData()
    {
        return $"SimpleGoal;{Name};{Description};{Points};{IsCompleted}";
    }
}