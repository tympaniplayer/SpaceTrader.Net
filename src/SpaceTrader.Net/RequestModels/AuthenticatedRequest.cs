namespace SpaceTrader.Net.RequestModels
{
    public abstract class AuthenticatedRequest
    {
        public string Token { get; set; }
    }
}