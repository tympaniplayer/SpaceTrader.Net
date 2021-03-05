using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SpaceTrader.Net.Models;
using SpaceTrader.Net.ResponseModels;

namespace SpaceTrader.Net.Service
{
    public class SpaceTraderService : ISpaceService
    {
        private HttpClient _httpClient;
        private static string baseUrl = "https://api.spacetraders.io";

        private JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        public string Username { get; private set; }
        public string Token { get; private set; }
        public SpaceTraderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void Initialize(string username, string token)
        {
            Username = username;
            Token = token;
        }

        public async Task<User> GetUser()
        {
            var uri = $"{Constants.userResource}/{Username}?token={Token}";
            var responseString = await _httpClient.GetStringAsync(uri);

            var userResponse = JsonSerializer.Deserialize<GetUserResponse>(responseString, options);
            return userResponse.User;
        }
    }
}