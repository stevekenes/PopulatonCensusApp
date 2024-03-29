﻿using System.Collections.Generic;
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

        public async Task<int> DeleteAsync(Person person)
        {
            _context.Remove(person);
            var rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected;
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
            var persons = _context.Persons.OrderBy(p => p.FirstName).ToList();
            return persons;
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();
            var updatedPerson = await SellectByIdAsync(person.Id);
            return updatedPerson;
        }

        public IList<Person> SellectByGender(string gender)
        {
            var persons = _context.Persons.Where(g => g.Gender == gender)
                .OrderBy(p => p.FirstName).ToList();
            return persons;
        }

        public IList<Person> SellectByStateOfOrigin(string state)
        {
            var origin = _context.Persons.Where(s => s.StateOfOrigin == state)
                .OrderBy(p => p.FirstName).ToList();
            return origin;
        }

        public IList<Person> SellectByOccupation(string occupation)
        {
            var job = _context.Persons.Where(o => o.Occupation == occupation)
                .OrderBy(p => p.FirstName).ToList();
            return job;
        }
    }
}
