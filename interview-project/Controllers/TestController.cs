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

        [HttpPost("reversearray/")]
        public IActionResult GetFibonacci(int[] arr)
        {
            var result = _testService.ReverseArray(arr);

            return Ok(result);

            /**
             * 
             * Complexity:
               Time Complexity: O(n) — The array is traversed once.
               Space Complexity: O(1) — No additional memory is used.
             */
        }

        [HttpPost("sortarray/")]
        public IActionResult GetSortArray(int[] arr)
        {
            var result = _testService.GetSortArray(arr);

            return Ok(result);
        }

        [HttpPost("romantoint/")]
        public IActionResult RomanToInt(string s)
        {
            /*
             * https://leetcode.com/problems/roman-to-integer/
             */
            var result = _testService.RomanToInt(s);

            return Ok(result);
        }

    }
}
