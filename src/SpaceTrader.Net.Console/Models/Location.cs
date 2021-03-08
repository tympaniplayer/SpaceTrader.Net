using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class Location
    {
        public string Symbol { get; set; }
        public string Type { get; set; }
        public string name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public IList<MarketplaceItem> Marketplace { get; set; }
    }
}