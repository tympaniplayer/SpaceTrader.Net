using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class CreateFlightPlanResponse : IResponse
    {
        public FlightPlan FlightPlan { get; set; }
    }
}