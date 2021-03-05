using System.Threading.Tasks;
using SpaceTrader.Net.Models;

namespace SpaceTrader.Net.Service
{
    public interface ISpaceService
    {
        public void Initialize(string username, string token);
        public Task<User> GetUser();
    }
}