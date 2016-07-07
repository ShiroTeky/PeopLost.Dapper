
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Persons;


namespace PeopLost.Service.Persons
{
    public partial class PersonService: IPersonService
    {
        IRepository<Person> personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            this.personRepository = personRepository;
        }

        public virtual void DeletePerson(Person person)
        {
            personRepository.Delete(person);
        }

        public virtual Person GetPersonById(int PersonId)
        {
            return personRepository.GetById(PersonId);
        }

        public virtual void InsertPerson(Person person)
        {
            personRepository.Insert(person);
        }

        public virtual void UpdatePerson(Person person)
        {
            personRepository.Update(person);
        }
    }
}
