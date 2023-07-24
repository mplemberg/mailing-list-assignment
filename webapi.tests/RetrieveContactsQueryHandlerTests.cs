using webapi.Application.RetrieveContacts;
using webapi.Data;
using webapi.Models;

namespace webapi.tests
{
    [TestClass]
    public class RetrieveContactsQueryHandlerTests
    {
        private ContactsRepository getRepository()
        {
            ContactsRepository repository = new ContactsRepository();
            repository.add(new Contact("steve@gmail.com","Steve", "Gonzalez"));
            repository.add(new Contact("sara@gmail.com", "Sara", "Wilkins"));
            repository.add(new Contact("abbyg@gmail.com", "Abby", "Gonzalez"));
            return repository;
        }
        [TestMethod]
        public void HandleShouldOrderByLastNameAscendingByDefault()
        {
            //arrange
            ContactsRepository repository = getRepository();
            RetrieveContactsQueryHandler queryHandler = new RetrieveContactsQueryHandler(repository);
            RetrieveContactsQuery query = new RetrieveContactsQuery();

            //act
            var contacts = queryHandler.handle(query);

            //assert
            Assert.AreEqual("abbyg@gmail.com", contacts.First().email);
        }

        [TestMethod]
        public void HandleShouldOrderByFirstNameDescendingWhenSpecified()
        {
            ContactsRepository repository = getRepository();
            RetrieveContactsQueryHandler queryHandler = new RetrieveContactsQueryHandler(repository);
            RetrieveContactsQuery query = new RetrieveContactsQuery { order = "desc"};

            var contacts = queryHandler.handle(query);

            Assert.AreEqual("sara@gmail.com", contacts.First().email);
        }

        [TestMethod]
        public void HandleShouldReturnNoContactsWhenLastNameDoesntMatch()
        {
            ContactsRepository repository = getRepository();
            RetrieveContactsQueryHandler queryHandler = new RetrieveContactsQueryHandler(repository);
            RetrieveContactsQuery query = new RetrieveContactsQuery { lastName="Seinfeld" };

            var contacts = queryHandler.handle(query);

            Assert.AreEqual(0, contacts.Count());
        }

        [TestMethod]
        public void HandleShouldReturnMatchingLastNameAndRegardlessOfCase()
        {
            ContactsRepository repository = getRepository();
            RetrieveContactsQueryHandler queryHandler = new RetrieveContactsQueryHandler(repository);
            RetrieveContactsQuery query = new RetrieveContactsQuery { lastName = "wilkins" };

            var contacts = queryHandler.handle(query);

            Assert.AreEqual("sara@gmail.com", contacts.First().email);
        }
    }
}