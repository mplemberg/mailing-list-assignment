using webapi.Models;

namespace webapi.Data
{
    public interface IContactsRepository
    {
        Contact add(Contact contact);
        List<Contact> getAll();
    }
}