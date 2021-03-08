using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetLocationInfoResponse : IResponse
    {
        public Location Planet { get; set; }
    }
}