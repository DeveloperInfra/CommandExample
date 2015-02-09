using System;
using System.Collections.Generic;
using System.Web.Http;
using CommandExample.Domain.Commands;

namespace CommandExample.Api.Controllers
{
    [RoutePrefix("api/Example")]
    public class ExampleController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var command = new GetExample();
            // Optionally set params

            return command.Commander.Handle(command);
        }

        // GET api/values/5
        public string Get(int id)
        {
            var command = new GetExample();
            // Optionally set params

            string response;
            try
            {
                response = command.Commander.Handle(command)[id - 1];
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}