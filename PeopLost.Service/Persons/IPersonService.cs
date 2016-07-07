
using PeopLost.Core.Domain.Persons;
namespace PeopLost.Service.Persons
{
    public partial interface IPersonService
    {
        /// <summary>
        /// Deletes a  person
        /// </summary>
        /// <param name="person">Person</param>
        void DeletePerson(Person person);

        /// <summary>
        /// Gets a news
        /// </summary>
        /// <param name="PersonId">The Person identifier</param>
        /// <returns>Person</returns>
        Person GetPersonById(int PersonId);



        /// <summary>
        /// Inserts a Person item
        /// </summary>
        /// <param name="news">Person</param>
        void InsertPerson(Person person);

        /// <summary>
        /// Updates the Person item
        /// </summary>
        /// <param name="Person">Person item</param>
        void UpdatePerson(Person Person);

    }
}
