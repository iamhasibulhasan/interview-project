namespace interview_project.Domain
{
    public sealed class Person
    {
        // Private field [Encapsulation]
        private string name;

        // Public property to access the private field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
