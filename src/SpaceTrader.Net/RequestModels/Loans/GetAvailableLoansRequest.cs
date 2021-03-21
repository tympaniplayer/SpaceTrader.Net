namespace SpaceTrader.Net.RequestModels.Loans
{
    public class GetAvailableLoansRequest : AuthenticatedRequest, IRequest
    {
        public string BuildRoute()
        {
            return "game/loans";
        }
    }
}