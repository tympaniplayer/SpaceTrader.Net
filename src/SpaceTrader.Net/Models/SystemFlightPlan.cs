using System;

namespace SpaceTrader.Net.Models
{
    public class SystemFlightPlan
    {
       public string Id { get; set; } 
       public string ShipId { get; set; }
       public DateTime CreatedAt { get; set; }
       public DateTime ArrivesAt { get; set; }
       public string From { get; set; }
       public string To { get; set; }
       public string Username { get; set; }
       public string ShipType { get; set; }
    }
}