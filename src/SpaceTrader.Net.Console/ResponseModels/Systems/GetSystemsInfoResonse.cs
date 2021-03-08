using System.Collections.Generic;
namespace SpaceTrader.Net.ResponseModels
{
    public class GetSystemsInfoResponse : IResponse
    {
        public IList<SpaceTrader.Net.Models.System> Systems { get; set; }
    }
}