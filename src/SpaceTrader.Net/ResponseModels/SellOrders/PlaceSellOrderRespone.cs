using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.SellOrders
{
    public class PlaceSellOrderResponse : IResponse
    {
        public int Credits { get; set; }
        public IList<MarketplaceItem> Order { get; set; }
        public UserShip Ship { get; set; }
    }
}