using System;
using System.Net.Http;
using System.Threading.Tasks;
using SpaceTrader.Net.Service;

namespace SpaceTrader.Net
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(Constants.baseUrl)
            };
            var spacetraders = new SpaceTraderService(httpClient);

            spacetraders.Initialize("", "");

            var user = await spacetraders.GetUser();

            Console.WriteLine($"Welcome back: {user.Username}");
            Console.WriteLine($"You have {user.Credits} available.");

            Console.WriteLine("Hello World!");
        }
    }
}
