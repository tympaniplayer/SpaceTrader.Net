using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetLocationsResponse : IResponse
    {
        public IList<Location> Locations { get; set; }
    }
}