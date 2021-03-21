using SpaceTrader.Net.RequestModels;
using SpaceTrader.Net.ResponseModels;

namespace SpaceTrader.Net.Endpoints
{
    public abstract class BaseEndpoint<TRequest, TResponse> where TRequest : IRequest
                                                            where TResponse : IResponse
    {

    }
}