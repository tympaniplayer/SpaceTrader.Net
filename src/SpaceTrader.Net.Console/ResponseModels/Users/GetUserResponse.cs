using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetUserResponse : IResponse
    {
        public User User { get; set; }
    }
}