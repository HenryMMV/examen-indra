using Examen.Domain.Interfaces;
using Examen.Domain.Models;
using Examen.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infra.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        protected readonly ExamenDbContext _context;

        public PersonRepository(ExamenDbContext context)
        {
            _context = context;
        }

        public async Task<Person> DeletePerson(Guid id)
        {
            var person = new Person { Id = id };
            _context.Remove(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> InsertPerson(Person person)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<Person> ListPerson(Guid id)
        {
            return await _context.Person.AsNoTrackingWithIdentityResolution().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Person>> ListPersons()
        {
            return await _context.Person.AsNoTrackingWithIdentityResolution().ToListAsync();
        }

        public async Task<Person> UpdatePerson(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();
            return person;
        }
    }
}
