namespace webapi.Models
{
    public class Contact
    {

        public Contact(string email, string firstName, string lastName)
        {

            Id = Guid.NewGuid();
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Guid Id { get; }
        public string email { get; }
        public string firstName { get; }
        public string lastName { get; }
    }
}
