using Microsoft.AspNetCore.Mvc;

namespace FluentApiValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetWeatherForecast")]
        public IActionResult Get(TestModel testModel)
        {
            var a = ModelState;

            return Ok("test model post metedou");
        }
    }
}