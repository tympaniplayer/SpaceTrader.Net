using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class User
    {
        public string Username { get; set; }
        public int Credits { get; set; }
        public List<UserShip> Ships { get; set; }
    }
}