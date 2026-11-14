using System;
using System.Collections.Generic;
using System.Linq;

var parter = new Zone("Партер", 100m);
var middle = new Zone("Середина", 150m);
var vip = new Zone("VIP", 250m);

var hall1 = new Hall("Зал 1");
for(int row = 1; row <= 6; row++)
{
    for(int number = 1; number <= 8; number++)
    {
        Zone zone;
         if (row <= 2)
            zone = parter;
        else if (row <= 4)
            zone = middle;
        else
            zone = vip;
        hall1.Seats.Add(new Seat(row, number, zone));
    }
}


var film1 = new Film("Інтерстеллар", "Фантастика", 169, "Подорож крізь червоточину");
var film2 = new Film("Гладіатор", "Історичний", 155, "Римський воїн мститься імператору");
var film3 = new Film("Шрек", "Мультфільм", 90, "Огр рятує принцесу");

var session1 = new Session(film1, hall1, new DateTime(2026, 11, 15, 12, 0, 0));
var session2 = new Session(film2, hall1, new DateTime(2026, 11, 15, 15, 30, 0));
var session3 = new Session(film3, hall1, new DateTime(2026, 11, 15, 18, 30, 0));
var session4 = new Session(film1, hall1, new DateTime(2026, 11, 16, 14, 0, 0));
var session5 = new Session(film2, hall1, new DateTime(2026, 11, 16, 19, 0, 0));

var sessions = new List<Session> { session1, session2, session3, session4, session5};

var schedule = sessions.OrderBy(s => s.Start);

foreach (var s in schedule)
{
    var end = s.Start.AddMinutes(s.Film.DurationMinutes);
    Console.WriteLine($"{s.Film.Title} ({s.Film.Genre}) {s.Start:dd.MM HH:mm} - {end:HH:mm}, {s.Hall.Name}");
}

var office = new BoxOffice();

var ticket = office.BuyTicket(session1, hall1.Seats[0]);
Console.WriteLine(ticket != null ? $"Куплено, ціна {ticket.Price}" : "Місце зайняте");

var again = office.BuyTicket(session1, hall1.Seats[0]);
Console.WriteLine(again != null ? "Куплено" : "Місце зайняте");


var groupSeats = new List<Seat> { hall1.Seats[1], hall1.Seats[2], hall1.Seats[3] };
var groupTickets = office.BuyTickets(session1, groupSeats);
Console.WriteLine(groupTickets != null ? $"Куплено {groupTickets.Count} квитків на {groupTickets.Sum(t => t.Price)} грн" : "Хтось із місць зайнятий");

var conflict = office.BuyTickets(session1, new List<Seat> { hall1.Seats[3], hall1.Seats[4] });
Console.WriteLine(conflict != null ? "Куплено" : "Хтось із місць зайнятий");
    

