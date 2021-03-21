using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Locations
{
    public class GetLocationsResponse : IResponse
    {
        public IList<BaseLocation> Locations { get; set; }
    }
}