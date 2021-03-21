namespace SpaceTrader.Net.RequestModels.Loans
{
    public class PayoffLoanRequest : AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string LoanId { get; set; }

        public string BuildRoute()
        {
            return $"users/{Username}/loans/{LoanId}";
        }
    }
}