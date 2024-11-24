namespace interview_project.Domain
{
    public sealed class MethodOverloading
    {
        // Method with two integer parameters
        public int Add(int a, int b)
        {
            return a + b;
        }
        // Overloaded method with three integer parameters
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method with two double parameters
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Overloaded method with string parameters
        public string Add(string a, string b)
        {
            return a + b;  // Concatenates strings
        }
    }
}
