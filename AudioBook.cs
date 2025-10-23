// AudioBook.cs
using System;

public class AudioBook : IMediaItem
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Status { get; set; }
    public string Narrator { get; set; } // Унікальне поле: Диктор
    public TimeSpan Duration { get; set; } // Унікальне поле: Загальна тривалість

    public void DisplayInfo()
    {
        Console.WriteLine($"[Аудіокнига] '{Title}' - Диктор: {Narrator} ({Year}). Тривалість: {Duration.Hours} год. Статус: {Status}");
    }
}