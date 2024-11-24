using Microsoft.AspNetCore.Mvc;

namespace interview_project.Application.Interfaces
{
    public interface ITestService
    {
        public Task<IActionResult> GetTest();
        public int[] GetFibonacci(int num);
    }
}
