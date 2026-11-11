using System;
using System.Collections.Generic;

public class Film
{
    public string Title { get; }
    public string Genre { get; }
    public int DurationMinutes { get; }
    public string Description { get; }

    public Film(string title, string genre, int durationMinutes, string description)
    {
        Title = title;
        Genre = genre;
        DurationMinutes = durationMinutes;
        Description = description;
    }
}