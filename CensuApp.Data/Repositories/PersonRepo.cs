using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CensusApp.Data.ContextClasses;
using CensusApp.Data.Entities;
using CensusApp.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CensusApp.Data.Repositories
{
    public class PersonRepo : IPersonRepo
    {
        private readonly CensusDbContext _context;
        private readonly ILogger<PersonRepo> _logger;

        public PersonRepo(CensusDbContext context, ILogger<PersonRepo> logger)
        {
            _context = context;
            _logger = logger;
        }

        public Task<Person> DeleteAsync(Person person)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Person> Insert(Person person)
        {
            var personToInsert = await _context.Persons.AddAsync(person);
            var changeCount = _context.SaveChangesAsync();
            if (changeCount.Result > 0)
            {
                //do something
                _logger.LogDebug("Data inserted successfully");
            }
            return personToInsert.Entity;
        }

        public async Task<Person> SellectByIdAsync(int id)
        {
            var person = await _context.Persons.Where(p => p.Id == id).FirstOrDefaultAsync();
            return person;
        }

        public IList<Person> SellectAll()
        {
            var persons = _context.Persons.ToList();
            return persons;
        }

        public Task<Person> UpdateAsync(Person person)
        {
            throw new System.NotImplementedException();
        }

        public IList<Person> SellectByGender(string gender)
        {
            var persons = _context.Persons.Where(g => g.Gender == gender).ToList();
            return persons;
        }

        public IList<Person> SellectByStateOfOrigin(string state)
        {
            var origin = _context.Persons.Where(s => s.StateOfOrigin == state).ToList();
            return origin;
        }

        public IList<Person> SellectByOccupation(string occupation)
        {
            var job = _context.Persons.Where(o => o.Occupation == occupation).ToList();
            return job;
        }
    }
}
