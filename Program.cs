using System;
using System.Collections.Generic;

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
Console.WriteLine(hall1.Seats.Count);