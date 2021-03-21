using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetFlightPlanInfoResponse : IResponse
    {
        public UserFlightPlan FlightPlan { get; set; }
    }
}