using System;
using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class UserShip : BaseShip
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public List<Cargo> Cargo { get; set; }
        public int SpaceAvailable { get; set; }
    }
}