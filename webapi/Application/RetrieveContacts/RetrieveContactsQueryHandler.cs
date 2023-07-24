using webapi.Data;
using webapi.Models;

namespace webapi.Application.RetrieveContacts
{
    public class RetrieveContactsQueryHandler : IRetrieveContactsQueryHandler
    {
        private IContactsRepository contactsRepository;

        public RetrieveContactsQueryHandler(IContactsRepository contactsRepository)
        {
            this.contactsRepository = contactsRepository;
        }
        public List<Contact> handle(RetrieveContactsQuery query)
        {
            List<Contact> contacts = contactsRepository.getAll();

            if (!String.IsNullOrEmpty(query.lastName))
            {
                contacts = contacts.Where(contact => contact.lastName.ToUpper() == query.lastName.ToUpper()).ToList();
            }

            if (query.order == RetrieveContactsQuery.ORDER_DESCENDING)
            {
                contacts = contacts.OrderByDescending(contact => contact.lastName.ToUpper()).ThenByDescending(contact => contact.firstName.ToUpper()).ToList();
            }
            else
            {
                contacts = contacts.OrderBy(contact => contact.lastName.ToUpper()).ThenBy(contact => contact.firstName.ToUpper()).ToList();
            }
            return contacts;
        }
    }
}
