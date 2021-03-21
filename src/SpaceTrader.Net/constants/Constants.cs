namespace SpaceTrader.Net
{
    public static class Constants
    {
        public static string baseUrl = "https://api.spacetraders.io";
        public static string userResource = "/users";
        public static string gameResource = "/game";
        public static string listLoansResource = $"{gameResource}/loans";
        public static string getLoansResource = $"{userResource}/loans";
    }
}