using System;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonus) 
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonus = bonus;
        _completedCount = 0;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        int totalPoints = Points;

        if (_completedCount >= _requiredCount)
        {
            IsCompleted = true;
            totalPoints += _bonus;
            Console.WriteLine($"{Name} goal fully completed! You earned {totalPoints} points including bonus!");
        }
        else
        {
            Console.WriteLine($"Progress on {Name}. You earned {Points} points. Completed {_completedCount}/{_requiredCount} times.");
        }
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : $"[{_completedCount}/{_requiredCount}]";
    }

    public override string SaveData()
    {
        return $"ChecklistGoal;{Name};{Description};{Points};{_requiredCount};{_bonus};{_completedCount}";
    }
}