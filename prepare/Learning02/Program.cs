using System;
using System.Collections.Generic;

// Step 1: Implementing the Job class
public class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

// Step 2: Implementing the Resume class
public class Resume
{
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}

// Step 3: Creating instances of the Job class and adding them to a Resume
class Program
{
    static void Main(string[] args)
    {
        // Creating the first job
        Job job1 = new Job();
        job1.JobTitle = "Software Developer";
        job1.Company = "Tech Solutions Ltd";
        job1.StartYear = 2018;
        job1.EndYear = 2021;

        // Creating the second job
        Job job2 = new Job();
        job2.JobTitle = "Web Developer";
        job2.Company = "Web Innovators Inc";
        job2.StartYear = 2021;
        job2.EndYear = 2023;

        // Creating a new resume and assigning a name
        Resume myResume = new Resume();
        myResume.Name = "Stephen Orinyo";

        // Adding the jobs to the resume
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        // Step 4: Displaying the resume details
        myResume.Display();
    }
}