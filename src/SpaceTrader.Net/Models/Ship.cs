using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class ShipForSale : BaseShip
    {
        public IList<PurchaseLocation> PurchaseLocations { get; set; }
    }
}