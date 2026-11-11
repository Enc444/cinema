using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

public class Session
{
    public Film Film { get; }
    public Hall Hall { get; }
    public DateTime Start { get; }
    public HashSet<Seat> TakenSeats { get; }

    public Session(Film film, Hall hall, DateTime start)
    {
        Film = film;
        Hall = hall;
        Start = start;
        TakenSeats = new HashSet<Seat>();
    }
}