using System;
using System.Net.Http;
using SimpleInjector;

namespace CommandExample.Api.Services
{
    internal sealed class RequestMessageProvider : IRequestMessageProvider
    {
        private readonly Lazy<HttpRequestMessage> _message;

        public RequestMessageProvider(Container container)
        {
            _message = new Lazy<HttpRequestMessage>(container.GetCurrentHttpRequestMessage);
        }

        public HttpRequestMessage CurrentMessage
        {
            get { return _message.Value; }
        }
    }
}