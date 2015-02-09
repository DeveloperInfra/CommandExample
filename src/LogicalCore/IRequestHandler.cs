namespace LogicalCore
{
    //public RequestHandler<TRequest, TResponse> : IReqestHandler()
    //{
    //    TResponse Handle(TRequest request);
    //}

    public interface IRequestHandler<TRequest, TResponse>
    {
        TResponse Handle(TRequest request);
    }


}