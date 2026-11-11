using System;
using System.Collections.Generic;

public class Zone
{
    public string Name { get; }
    public decimal Price { get; }

    public Zone(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}