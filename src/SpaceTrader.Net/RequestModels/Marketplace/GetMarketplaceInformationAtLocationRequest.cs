namespace SpaceTrader.Net.RequestModels.Marketplace
{
    public class GetMarketplaceInformationAtLocationRequest : AuthenticatedRequest, IRequest
    {
        public string Symbol { get; set; }

        public string BuildRoute()
        {
            return $"game/locations/{Symbol}/marketplace";
        }
    }
}