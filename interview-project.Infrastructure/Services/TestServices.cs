using interview_project.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace interview_project.Infrastructure.Services
{
    public sealed class TestServices : ITestService
    {
        public TestServices()
        {

        }
        public async Task<IActionResult> GetTest()
        {
            throw new NotImplementedException();
        }
    }
}
