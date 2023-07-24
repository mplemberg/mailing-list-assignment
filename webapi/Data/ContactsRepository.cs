using webapi.Models;

namespace webapi.Data
{
    public class ContactsRepository : IContactsRepository
    {
        private List<Contact> contacts = new List<Contact>();

        public Contact add(Contact contact)
        {
            contacts.Add(contact);
            return contact;
        }

        public List<Contact> getAll()
        {
            return contacts;
        }
    }
}
