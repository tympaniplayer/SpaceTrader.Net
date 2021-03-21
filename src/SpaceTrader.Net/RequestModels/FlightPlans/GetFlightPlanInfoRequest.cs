namespace SpaceTrader.Net.RequestModels.FlightPlans
{
    public class GetFlightPlanInfoRequest : AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string FlightPlanId { get; set; }

        public string BuildRoute()
        {
            return $"users/{Username}/flight-plants/{FlightPlanId}";
        }
    }
}