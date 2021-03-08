using System.Collections.Generic;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.ResponseModels
{
    public class GetAvailableLoansResponse : IResponse
    {
        public IList<AvailableLoan> Loans { get; set; }
    }
}