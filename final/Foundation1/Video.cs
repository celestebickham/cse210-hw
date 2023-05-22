using System;

public class Video
{
    public string _title;
    public string _author;
    public string _lengthInSeconds;

    public List<Comment> _comment = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds}");
        Console.WriteLine($"Number of comments: {_comment.Count}");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comment)
        {
            comment.Display();
        }

        Console.WriteLine("");
    }
}
