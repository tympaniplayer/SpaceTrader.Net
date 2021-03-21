using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetAllActiveFlightPlansResponse : IResponse
    {
        public List<SystemFlightPlan> FlightPlans { get; set; }     
    }
}