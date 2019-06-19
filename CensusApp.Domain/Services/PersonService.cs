using AutoMapper;
using CensusApp.Data.Entities;
using CensusApp.Data.Repositories.Interfaces;
using CensusApp.Domain.RequestModels;
using CensusApp.Domain.Responses;
using CensusApp.Domain.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CensusApp.Domain.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepo _personRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<PersonService> _logger;

        public PersonService(IPersonRepo personRepo, IMapper mapper, 
            ILogger<PersonService> logger)
        {
            _personRepo = personRepo;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<PersonResponse> Create(PersonRequest person)
        {
            _logger.LogInformation("Attempting to create person in service");
            var pesin = _mapper.Map<Person>(person);
            var createdPerson = await _personRepo.Insert(pesin);
            var personQuery = _mapper.Map<PersonResponse>(createdPerson);
            return personQuery;
        }

        public Task<PersonResponse> DeleteAsync(PersonResponse person)
        {
            throw new NotImplementedException();
        }

        public IList<PersonResponse> GetAll()
        {
            var persons = _personRepo.SellectAll();
            var personsQuery = _mapper.Map<IList<PersonResponse>>(persons);
            return personsQuery;
        }

        public async Task<PersonResponse> GetByIdAsync(int id)
        {
            var person = await _personRepo.SellectByIdAsync(id);
            var personQuery = _mapper.Map<PersonResponse>(person);
            return personQuery;
        }

        public IList<PersonResponse> GetByGender(string gender)
        {
            var persons = _personRepo.SellectByGender(gender);
            var personsQuery = _mapper.Map<IList<PersonResponse>>(persons);
            return personsQuery;
        }

        public Task<PersonResponse> ModifyAsync(PersonResponse person)
        {
            throw new NotImplementedException();
        }

        public IList<PersonResponse> GetByStateOfOrigin(string state)
        {
            var origin = _personRepo.SellectByStateOfOrigin(state);
            var originQuery = _mapper.Map<IList<PersonResponse>>(origin);
            return originQuery;
        }

        public IList<PersonResponse> GetByOccupation(string occupation)
        {
            var job = _personRepo.SellectByOccupation(occupation);
            var jobQuery = _mapper.Map<IList<PersonResponse>>(job);
            return jobQuery;
        }
    }
}
