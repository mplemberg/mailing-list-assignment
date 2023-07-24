using webapi.Data;
using webapi.Models;

namespace webapi.Application.AddContact
{
    public class AddContactCommandHandler : IAddContactCommandHandler
    {
        private IContactsRepository contactsRepository;

        public AddContactCommandHandler(IContactsRepository contactsRepository)
        {
            this.contactsRepository = contactsRepository;
        }
        public Contact handle(AddContactCommand command)
        {
            Contact contact = new Contact(command.email, command.firstName, command.lastName);

            contact = contactsRepository.add(contact);
            return contact;
        }
    }
}
