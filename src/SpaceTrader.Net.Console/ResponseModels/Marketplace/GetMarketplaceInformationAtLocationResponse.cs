using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetMarketplaceInformationAtLocationResponse : IResponse
    {
        public Location Planet { get; set; }
    }
}