using System.Collections.Generic;

namespace SpaceTrader.Net.ResponseModels.Systems
{
    public class GetSystemsInfoResponse : IResponse
    {
        public IList<SpaceTrader.Net.Models.System> Systems { get; set; }
    }
}