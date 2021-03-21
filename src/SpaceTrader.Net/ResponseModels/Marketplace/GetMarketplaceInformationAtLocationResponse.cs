using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Marketplace
{
    public class GetMarketplaceInformationAtLocationResponse : IResponse
    {
        public LocationWithMarketplace Planet { get; set; }
    }
}