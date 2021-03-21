using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class LocationWithMarketplace : BaseLocation
    {
        
        public IList<MarketplaceItem> Marketplace { get; set; }
    }
}