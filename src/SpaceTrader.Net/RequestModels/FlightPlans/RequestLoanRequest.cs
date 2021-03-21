namespace SpaceTrader.Net.RequestModels.FlightPlans
{
    public class RequestLoanRequest: AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string Type { get; set; }

        public string BuildRoute()
        {
            return $"users/{Username}/loans";
        }
    }
}