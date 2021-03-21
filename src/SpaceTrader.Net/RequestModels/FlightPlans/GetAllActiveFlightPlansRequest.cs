namespace SpaceTrader.Net.RequestModels.FlightPlans
{
    public class GetAllActiveFlightPlansRequest : AuthenticatedRequest, IRequest
    {
        public string Symbol { get; set; }
        public string BuildRoute()
        {
            return $"systems/{Symbol}/flight-plans";
        }
    }
}