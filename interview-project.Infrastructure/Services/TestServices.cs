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


    }
}
