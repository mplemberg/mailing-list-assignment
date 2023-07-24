using Microsoft.AspNetCore.Mvc;
using webapi.Application.AddContact;
using webapi.Application.RetrieveContacts;
using webapi.Models;

namespace webapi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private IAddContactCommandHandler addContactCommandHandler;
        private IRetrieveContactsQueryHandler retrieveContactsQueryHandler;

        public ContactsController(IAddContactCommandHandler addContactCommandHandler, IRetrieveContactsQueryHandler retrieveContactsQueryHandler) 
        {
            this.addContactCommandHandler = addContactCommandHandler;
            this.retrieveContactsQueryHandler = retrieveContactsQueryHandler;
        }
        // GET: api/<ContactsController>
        [HttpGet]
        public ActionResult<List<Contact>> Get([FromQuery] RetrieveContactsQuery query)
        {
            return retrieveContactsQueryHandler.handle(query);
        }


        // POST api/<ContactsController>
        [HttpPost]
        public ActionResult<Contact> Post([FromBody] AddContactCommand addContactCommand)
        {
            return addContactCommandHandler.handle(addContactCommand);
        }

    }
}
