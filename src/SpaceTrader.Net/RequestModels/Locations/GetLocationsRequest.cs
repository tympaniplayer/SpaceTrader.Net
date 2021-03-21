namespace SpaceTrader.Net.RequestModels.Locations
{
    public class GetLocationsRequest : AuthenticatedRequest, IRequest
    {
       public string Symbol { get; set; }
       public string BuildRoute()
       {
           return $"game/systems/{Symbol}/locations";
       }
    }
}