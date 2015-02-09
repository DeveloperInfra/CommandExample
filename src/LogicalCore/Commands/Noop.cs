namespace LogicalCore.Commands
{
    public class Noop : IRequest<Unit>
    {
        public Unit Execute()
        {
            return new Unit();
        }

        public class Handler : IRequestHandler<Noop, Unit>
        {
            public Unit Handle(Noop noop)
            {
                return new Unit();
            }
        }
    }


}