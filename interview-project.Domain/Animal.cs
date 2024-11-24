namespace interview_project.Domain
{
    // Here is the purpose of the sealed class is not inheriting the base class
    public /*sealed*/ class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
