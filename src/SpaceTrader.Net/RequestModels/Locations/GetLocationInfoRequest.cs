namespace SpaceTrader.Net.RequestModels.Locations
{
    public class GetLocationInfoRequest : AuthenticatedRequest, IRequest
    {
        public string Symbol { get; set; }

        public string BuildRoute()
        {
            return $"game/locations/{Symbol}";
        }
    }
}