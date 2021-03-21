namespace SpaceTrader.Net.RequestModels.Loans
{
    public class GetUserLoansRequest : AuthenticatedRequest, IRequest
    {
       public string Username { get; set; }
       public string BuildRoute()
       {
           return $"users/{Username}/loans";
       }
    }
}