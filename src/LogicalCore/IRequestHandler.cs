namespace LogicalCore
{
    //public RequestHandler<TRequest, TResponse> : IReqestHandler()
    //{
    //    TResponse Handle(TRequest request);
    //}

    public interface IRequestHandler<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest request);
    }


}