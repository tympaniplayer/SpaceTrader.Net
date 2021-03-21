using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class System
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public IList<BaseLocation> Locations { get; set; }
    }
}