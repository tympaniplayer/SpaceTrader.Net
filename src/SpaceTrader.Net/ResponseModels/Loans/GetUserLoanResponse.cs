using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels.Loans
{
    public class GetUserLoanResponse : IResponse
    {
        public IList<UserLoan> Loans { get; set; }
    }
}