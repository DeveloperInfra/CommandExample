using System.Net.Http;

namespace CommandExample.Api.Services
{
    public interface IRequestMessageProvider
    {
        HttpRequestMessage CurrentMessage { get; }
    }
}