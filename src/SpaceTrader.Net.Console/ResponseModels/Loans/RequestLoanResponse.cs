using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class RequestLoanResponse : IResponse
    {
        public User User { get; set; }
    }
}