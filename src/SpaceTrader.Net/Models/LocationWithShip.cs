using System.Collections.Generic;

namespace SpaceTrader.Net.Models
{
    public class LocationWithShip : BaseLocation
    {
        public IList<LocationShip> Ships { get; set; }
    }
}