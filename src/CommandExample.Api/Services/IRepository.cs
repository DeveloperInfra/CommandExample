using System.Collections.Generic;

namespace CommandExample.Api.Services
{
    public interface IRepository
    {
        List<string> Get();
    }
}