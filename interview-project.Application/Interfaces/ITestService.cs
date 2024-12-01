using Microsoft.AspNetCore.Mvc;

namespace interview_project.Application.Interfaces
{
    public interface ITestService
    {
        public Task<IActionResult> GetTest();
        public int[] GetFibonacci(int num);
        public int[] ReverseArray(int[] num);
        public List<int> GetSortArray(int[] num);
        public int RomanToInt(string s);
        public bool ValidParentheses(string s);
        public int SearchInsert(int[] nums, int target);
        public bool CheckIfExist(int[] arr);
    }
}
