using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using CommandExample.Domain;
using CommandExample.Domain.Commands;
using LogicalCore;

namespace CommandExample.Api
{
    public class Mediator
    {
        public TResponse Send<TResponse>(IRequest<TResponse> request)
        {
            var handler = GetHandler(request);
            TResponse result = handler.Handle(request);
            return result;
        }

        private IRequestHandler<IRequest<TResponse>, TResponse> GetHandler<TResponse>(IRequest<TResponse> request)
        {
            var handler = new GetExample.Handler();

            if (handler == null)
                throw new Exception("Handler not found");


            return handler;
        }

        private abstract class RequestHandler<TResult>
        {
            public abstract TResult Handle(IRequest<TResult> message);
        }

        private class RequestHandler<TCommand, TResult> : RequestHandler<TResult> where TCommand : IRequest<TResult>
        {
            private readonly IRequestHandler<TCommand, TResult> _inner;

            public RequestHandler(IRequestHandler<TCommand, TResult> inner)
            {
                _inner = inner;
            }

            public override TResult Handle(IRequest<TResult> message)
            {
                return _inner.Handle((TCommand)message);
            }
        }
    }
}