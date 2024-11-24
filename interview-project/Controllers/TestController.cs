using interview_project.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace interview_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [HttpGet("gettest")]
        public async Task<IActionResult> GetTest()
        {
            var result = await _testService.GetTest();

            return result;
        }

        [HttpGet("fibonacci/{num}")]
        public IActionResult GetFibonacci(int num)
        {
            var result = _testService.GetFibonacci(num);

            return Ok(result);
        }
    }
}
