using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Intro to C#", "Tech Guru", 300);
        Video video2 = new Video("OOP Concepts", "Dev Expert", 600);
        Video video3 = new Video("Encapsulation Explained", "Code Master", 480);

        // Add comments to videos
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Loved it!"));

        video2.AddComment(new Comment("David", "Helped a lot!"));
        video2.AddComment(new Comment("Eve", "Thanks for the insights."));
        video2.AddComment(new Comment("Frank", "Well done."));

        video3.AddComment(new Comment("Grace", "Clear and concise."));
        video3.AddComment(new Comment("Heidi", "Perfect for beginners."));
        video3.AddComment(new Comment("Ivan", "I learned so much!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}