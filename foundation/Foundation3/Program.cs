using System;
using System.Collections.Generic;

// Base class
public class Activity
{
    private DateTime _date;
    private int _lengthInMinutes; // Private member variable for length

    // Constructor
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    // Public property to access the length of activity
    public int LengthInMinutes => _lengthInMinutes;

    // Virtual methods to override in derived classes
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    // Summary method
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}

// Derived class for Running
public class Running : Activity
{
    private double _distance; // Distance in miles

    // Constructor
    public Running(DateTime date, int lengthInMinutes, double distance) 
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / GetDistance();
}

// Derived class for Cycling
public class Cycling : Activity
{
    private double _speed; // Speed in mph

    // Constructor
    public Cycling(DateTime date, int lengthInMinutes, double speed) 
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed / 60) * LengthInMinutes;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;
}

// Derived class for Swimming
public class Swimming : Activity
{
    private int _laps; // Number of laps

    // Constructor
    public Swimming(DateTime date, int lengthInMinutes, int laps) 
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * 50 / 1000.0 * 0.62; // Convert to miles

    public override double GetSpeed() => (GetDistance() / LengthInMinutes) * 60;

    public override double GetPace() => LengthInMinutes / GetDistance();
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0), // 3 miles
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0), // 12 mph
            new Swimming(new DateTime(2022, 11, 5), 30, 20)   // 20 laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}