using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Users
{
    public class GetUserResponse : IResponse
    {
        public User User { get; set; }
    }
}