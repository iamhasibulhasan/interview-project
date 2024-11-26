using interview_project.Application.Interfaces;
using interview_project.Domain;
using Microsoft.AspNetCore.Mvc;

namespace interview_project.Infrastructure.Services
{
    public sealed class TestServices : ITestService
    {
        public TestServices()
        {

        }

        public int[] GetFibonacci(int n)
        {

            // Create an array to store the Fibonacci sequence
            int[] fibonacciArray = new int[n + 1];

            // Initialize the first two values
            if (n >= 0) fibonacciArray[0] = 0;
            if (n >= 1) fibonacciArray[1] = 1;

            // Calculate the rest of the sequence
            for (int i = 2; i <= n; i++)
            {
                fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
            }

            return fibonacciArray;  // Return the full sequence as an array
        }

        public List<int> GetSortArray(int[] num)
        {
            //[1,5,4,8,2,1,3,8]

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < num.Count(); i++)
                {
                    if (num[i - 1] > num[i])
                    {
                        int temp = num[i - 1];
                        num[i - 1] = num[i];
                        num[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            return new List<int>(num);
        }
        public int RomanToInt(string s)
        {
            // Leet code 13. Roman to Integer

            Dictionary<char, int> roman_map = new Dictionary<char, int>() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
            var ans = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {

                int num = roman_map[s[i]];
                if (4 * num < ans)
                {
                    ans -= num;
                }
                else
                {
                    ans += num;
                }
            }
            return ans;
        }

        public async Task<IActionResult> GetTest()
        {
            // Encapsulation
            Person person = new();
            person.Name = "Test";


            //Inheritance
            Dog dog = new();
            dog.Bark();
            dog.Eat(); // Inherit from animal class

            //Polymorphism
            //usually involves method overriding 
            Shape shape1 = new Circle();
            Shape shape2 = new Square();
            shape1.Draw();// Output: Drawing a circle
            shape2.Draw();// Output: Drawing a square

            //and method overloading same name with different parameter
            MethodOverloading methodOverloading = new MethodOverloading();
            methodOverloading.Add(1, 2);
            methodOverloading.Add(1, 2, 3);

            // Abstraction
            //Real-Time Example of Abstract Class in C#: Banking System
            SavingsAccount hasibulAccount = new("01212", "Hasibul Hasan");
            hasibulAccount.Deposit(100000);
            hasibulAccount.Withdraw(500);


            return null;
        }

        public int[] ReverseArray(int[] num)
        {
            //{ 1, 2, 3, 4, 5 };

            int left = 0;
            int right = num.Length - 1;

            while (left < right)
            {
                int temp = num[left];
                num[left] = num[right];
                num[right] = temp;

                left++;
                right--;
            }
            return num;
        }

        public bool ValidParentheses(string s)
        {
            /*
             * 20. Valid Parentheses
             * Input: s = "([])"
             * Output: true
             */

            int n = -1;
            while (s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else return false;
        }

        public int StrStr(string haystack, string needle)
        {
            /*
             * 28. Find the Index of the First Occurrence in a String
             * https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
             */
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            return -1;
        }
    }
}
