namespace SpaceTrader.Net.RequestModels.Locations
{
    public class GetDockedShipInfoAtLocationRequest : AuthenticatedRequest, IRequest
    {
       public string Symbol { get; set; }

       public string BuildRoute()
       {
           return $"game/locations/{Symbol}/ships";
       }
    }
}