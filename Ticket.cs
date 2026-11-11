using System;
using System.Collections.Generic;

public class Ticket
{
    public Session Session { get; }
    public Seat Seat { get; }
    public decimal Price => Seat.Zone.Price;

    public Ticket(Session session, Seat seat)
    {
        Session = session;
        Seat = seat;
    }
}
