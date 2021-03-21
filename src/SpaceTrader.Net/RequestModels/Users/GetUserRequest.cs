namespace SpaceTrader.Net.RequestModels.Users
{
    public class GetUserRequest : AuthenticatedRequest, IRequest
    {
        public string Username { get; set; }
        public string BuildRoute()
        {
            return $"users/{Username}";
        }
    }
}