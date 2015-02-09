using System;
using System.Collections.Generic;
using System.Web.Http;
using CommandExample.Api.Services;
using Serilog;

namespace CommandExample.Api.Controllers
{
    [RoutePrefix("api/Example")]
    public class ExampleController : ApiController
    {
        private readonly ILogger _logger;
        private readonly IRepository _repository;

        public ExampleController(IRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            _logger.Debug("Called ExampleController.Get()");

            //TODO: Change this out to call CommandExample.Domain.Commands.GetExample
            var response = _repository.Get();

            return response;
        }

        // GET api/values/3
        public string Get(int id)
        {
            //TODO: Change this out to call CommandExample.Domain.Commands.GetExample
            string response;
            try
            {
                response = _repository.Get()[id - 1];
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