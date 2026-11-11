using System;
using System.Collections.Generic;

using System.Collections.Generic;

public class Hall
{
    public string Name { get; }
    public List<Seat> Seats { get; }

    public Hall(string name)
    {
        Name = name;
        Seats = new List<Seat>();
    }
}