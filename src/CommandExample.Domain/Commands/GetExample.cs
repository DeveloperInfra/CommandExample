using System.Collections.Generic;

namespace CommandExample.Domain.Commands
{
    internal class GetExample : IRequest<List<string>>
    {
        // "params"

        internal class Handler : IRequestHandler<GetExample, List<string>>
        {
            public List<string> Handle(GetExample request)
            {
                return new List<string>
                {
                    "value1",
                    "value2",
                    "value3"
                };
            }
        }
    }
}