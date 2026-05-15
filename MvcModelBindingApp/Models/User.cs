namespace MvcModelBindingApp.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        // Complex type / nested model
        public Address Address { get; set; } = new Address();
    }
}