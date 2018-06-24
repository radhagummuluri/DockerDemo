using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerDemo.Api.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> log)
        {
            _logger = log;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var container = Convert.ToBoolean(Environment.GetEnvironmentVariable("IS_CONTAINER")) ? "from container" : "";
            var output = $"Api called {container}! My ID is {Environment.MachineName}";
            _logger.LogInformation(output);
            return output;
        }
    }
}
