using webapi.Models;

namespace webapi.Application.AddContact
{
    public interface IAddContactCommandHandler
    {
        Contact handle(AddContactCommand command);
    }
}