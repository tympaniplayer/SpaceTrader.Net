using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Loans
{
    public class RequestLoanResponse : IResponse
    {
        public User User { get; set; }
    }
}