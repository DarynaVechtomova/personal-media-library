// Book.cs
using System;

public class Book : IMediaItem
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Status { get; set; }
    public string Author { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"[Книга] '{Title}' - {Author} (2020). Статус: {Status}");
    }
}