using System.Collections.Generic;

namespace CommandExample.Domain.Commands
{
    public class GetExample : IRequest<List<string>>
    {
        public Handler Commander = new Handler();

        // "params"

        public class Handler : IRequestHandler<GetExample, List<string>>
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