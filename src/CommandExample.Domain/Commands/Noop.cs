namespace CommandExample.Domain.Commands
{
    internal class Noop : IRequest<Unit>
    {
        public Unit Execute()
        {
            return new Unit();
        }
    }

    internal class NoopHandler : IRequestHandler<Noop, Unit>
    {
        public Unit Handle(Noop noop)
        {
            return new Unit();
        }
    }
}