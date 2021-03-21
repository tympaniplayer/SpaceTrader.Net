using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Locations
{
    public class GetLocationInfoResponse : IResponse
    {
        public BaseLocation Planet { get; set; }
    }
}