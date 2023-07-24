using webapi.Models;

namespace webapi.Application.RetrieveContacts
{
    public interface IRetrieveContactsQueryHandler
    {
        List<Contact> handle(RetrieveContactsQuery query);
    }
}