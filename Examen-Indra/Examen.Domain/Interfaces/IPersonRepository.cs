using Examen.Domain.Models;

namespace Examen.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> ListPersons();
        Task<Person> ListPerson(Guid id);
        Task<Person> InsertPerson(Person person);
        Task<Person> UpdatePerson(Person person);
        Task<Person> DeletePerson(Guid id);
    }
}
