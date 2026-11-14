using System;
using System.Collections.Generic;
using System.Linq;

public class BoxOffice
{
    public Ticket? BuyTicket(Session session, Seat seat)
    {
        if (session.TakenSeats.Add(seat))
        {
            return new Ticket(session, seat);
        }
        return null;
    }

    public List<Ticket>? BuyTickets(Session session, List<Seat> seats)
    {
        if (seats.Any(seat => session.TakenSeats.Contains(seat)))
        {
            return null;
        }

        var tickets = new List<Ticket>();
        foreach (var seat in seats)
        {
            session.TakenSeats.Add(seat);
            tickets.Add(new Ticket(session, seat));
        }
        return tickets;
    }
}