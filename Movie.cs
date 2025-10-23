// Movie.cs
using System;

public class Movie : IMediaItem
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Status { get; set; }
    public string Director { get; set; } // Унікальне поле: Режисер
    public int RuntimeMinutes { get; set; } // Унікальне поле: Тривалість у хвилинах

    public void DisplayInfo()
    {
        Console.WriteLine($"[Фільм] '{Title}' - Реж. {Director} ({Year}). Тривалість: {RuntimeMinutes} хв. Статус: {Status}");
    }
}