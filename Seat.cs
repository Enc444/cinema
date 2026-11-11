using System;
using System.Collections.Generic;

public class Seat
{
    public int Row { get; }
    public int Number { get; }
    public Zone Zone { get; }

    public Seat(int row, int number, Zone zone)
    {
        Row = row;
        Number = number;
        Zone = zone;
    }
}