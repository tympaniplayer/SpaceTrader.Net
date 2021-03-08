using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class PlacePurchaseOrderResponse : IResponse
    {
        public int Credits { get; set; }
        public IList<MarketplaceItem> Order { get; set; }
        public UserShip Ship { get; set; }
    }
}