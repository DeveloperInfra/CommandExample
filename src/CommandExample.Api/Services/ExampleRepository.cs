using System.Collections.Generic;

namespace CommandExample.Api.Services
{
    public class ExampleRepository : IRepository
    {
        public List<string> Get()
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