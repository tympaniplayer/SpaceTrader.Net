using System;
using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class UserShip
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public List<Cargo> Cargo { get; set; }
        public int SpaceAvailable { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public int MaxCargo { get; set; }
        public int Speed { get; set; }
        public string Manufacturer { get; set; }
        public int Plating { get; set; }
        public int Weapons { get; set; }
    }
}