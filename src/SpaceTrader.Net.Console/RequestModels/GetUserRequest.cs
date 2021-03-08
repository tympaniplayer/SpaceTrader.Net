namespace SpaceTrader.Net.RequestModels
{
    public class GetUserRequest : AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string BuildRoute()
        {
            return string.Empty;
        }
    }
}