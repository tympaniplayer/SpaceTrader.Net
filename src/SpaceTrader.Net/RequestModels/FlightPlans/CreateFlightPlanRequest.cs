namespace SpaceTrader.Net.RequestModels.FlightPlans
{
    public class CreateFlightPlanRequest : AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string ShipId { get; set; }
        public string Destination { get; set; }

        public string BuildRoute()
        {
            return $"users/{Username}/flight-plans";
        }
    }
}