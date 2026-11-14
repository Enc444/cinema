using System;
using System.Collections.Generic;

public class BoxOffice
{
    public Ticket? BuyTicket(Session session, Seat seat)
    {
        if(session.TakenSeats.Add(seat))
        {
            return new Ticket(session, seat);
        }
        return null;
    }
}