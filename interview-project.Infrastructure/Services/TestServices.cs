﻿using interview_project.Application.Interfaces;
using interview_project.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

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

        public int SearchInsert(int[] nums, int target)
        {
            /*35. Search Insert Position
             * https://leetcode.com/problems/search-insert-position/description/
             * Input: nums = [1,3,5,6], target = 5
             * Output: 2
             */
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid; // Target found, return the position

                if (nums[mid] < target)
                    left = mid + 1; // Search the right half
                else
                    right = mid - 1; // Search the left half
            }

            // If not found, 'left' will be the insert position
            return left;


        }

        public bool CheckIfExist(int[] arr)
        {
            /*
             * 1346. Check If N and Its Double Exist
             * Input: arr = [10,2,5,3]
             * Output: true
             * Explanation: For i = 0 and j = 2, arr[i] == 10 == 2 * 5 == 2 * arr[j]
             */

            // the time complexity is O(n²)
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (arr[i] == 2 * arr[j])
            //            {
            //                return true;
            //            }
            //        }
            //    }
            //}

            // the total time complexity is O(n).
            HashSet<int> seen = new();
            foreach (int i in arr)
            {
                if (seen.Contains(2 * i) || (i % 2 == 0 && seen.Contains(i / 2)))
                {

                    return true;
                }
                seen.Add(i);
            }
            return false;
        }

        public int PassThePillow(int n, int time)
        {
            /*
             *2582. Pass the Pillow
             *
             *Input: n = 4, time = 5
             *Output: 2
             *Explanation: People pass the pillow in the following way: 1 -> 2 -> 3 -> 4 -> 3 -> 2.
             *After five seconds, the 2nd person is holding the pillow.
             */

            //List<int> list = Enumerable.Range(1,n).ToList();
            int cycleLength = 2 * (n - 1);       // Total steps in one forward-backward cycle
            int positionInCycle = time % cycleLength;

            if (positionInCycle < n - 1)         // Moving forward
            {
                return 1 + positionInCycle;
            }
            else                                // Moving backward
            {
                return n - (positionInCycle - (n - 1));
            }
        }

        public int LengthOfLastWord(string s)
        {
            /* 58. Length of Last Word
             * Input: s = "Hello World"
             * Output: 5
             * Explanation: The last word is "World" with length 5.
             * 
             */
            var split_text = s.Trim();
            var ok = split_text.Split();
            var res = ok[ok.Length - 1].Length;
            return res;
        }

        public int[] PlusOne(int[] digits)
        {
            /* 66. Plus One
             * Input: digits = [1,2,3]
             * Output: [1,2,4]
             * Explanation: The array represents the integer 123.
             * Incrementing by one gives 123 + 1 = 124.
             * Thus, the result should be [1,2,4].
             * 
             */
            var s = BigInteger.Parse(string.Join("", digits)) + 1;
            return s.ToString().Select(c => int.Parse(c.ToString())).ToArray();


        }

        public int MyAtoi(string s)
        {
            List<int> res = [];
            var sp = s.Trim().Split();
            foreach (var c in sp)
            {
                if (c != "0")
                {

                }
            }
            return 0;
        }

        public bool PalindromeCheck(string words)
        {
            /*
             * kayak.
             * deified.
             * rotator.
             * repaper.
             * deed.
             * peep.
             * wow.
             * noon.
             * */
            if (string.IsNullOrEmpty(words)) return false;

            words = words.Replace(" ", "").ToLower();

            int left = 0;
            int right = words.Length - 1;

            while (left < right)
            {
                if (words[left] != words[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;

        }
    }
}
