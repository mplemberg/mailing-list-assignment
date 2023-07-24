using System.ComponentModel.DataAnnotations;

namespace webapi.Application.AddContact
{
    public class AddContactCommand
    {
        public AddContactCommand(string lastName, string firstName, string email)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.email = email;
        }

        [Required]
        public string lastName { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string email { get; set; }

    }
}
