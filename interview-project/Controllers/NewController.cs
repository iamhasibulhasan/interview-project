using interview_project.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace interview_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private readonly INewServices _newServices;

        public NewController(INewServices newServices)
        {
            _newServices = newServices;
        }

        [HttpPost("hellotest/")]
        public IActionResult Get([FromBody] List<int> array)
        {
            //var result = _newServices.Get(s);

            return Ok();
        }
    }
}
