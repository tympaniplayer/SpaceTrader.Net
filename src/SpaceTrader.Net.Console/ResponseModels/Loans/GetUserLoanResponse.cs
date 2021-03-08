using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetUserLoanResponse : IResponse
    {
        public IList<UserLoan> Loans { get; set; }
    }
}