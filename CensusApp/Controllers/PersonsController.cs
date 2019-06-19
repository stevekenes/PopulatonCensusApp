using CensusApp.Domain.RequestModels;
using CensusApp.Domain.Responses;
using CensusApp.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CensusApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly ILogger<PersonsController> _logger;

        public PersonsController(IPersonService personService,
            ILogger<PersonsController> logger)
        {
            _personService = personService;
            _logger = logger;
        }

        //api/persons
        [HttpGet]
        public IActionResult GetPersons()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var persons = _personService.GetAll();
            return Ok(persons);
        }

        //api/persons/id
        [HttpGet("{id}", Name = "GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            PersonResponse person = null;
            person = await _personService.GetByIdAsync(id);
            if (person == null)
            {
                return NotFound($"The Person with the ID {id} cannot be found");
            }
            return Ok(person);
        }

        //api/persons/genderName/gender
        [HttpGet("{gender}/gender")]
        public IActionResult GetPersonsByGender(string gender)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var sex = _personService.GetByGender(gender);
            if (sex == null)
            {
                return NotFound($"The gender name {gender} does not exist");
            }
            return Ok(sex);
        }

        //api/persons/stateName/state
        [HttpGet("{state}/state")]
        public IActionResult GetPersonsByState(string state)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var origin = _personService.GetByStateOfOrigin(state);
            if (origin == null)
            {
                return NotFound($"{state} state does not exist");
            }
            return Ok(origin);
        }


        //api/persons/work/occupationName
        [HttpGet("work/{occupation}")]
        public IActionResult GetByOccupation(string occupation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var job = _personService.GetByOccupation(occupation);
            if (job == null)
            {
                return NotFound($"{occupation} state does not exist");
            }
            return Ok(job);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePerson([FromBody] PersonRequest personRequest)
        {
            if (personRequest == null)
                return BadRequest(ModelState);

            var personToCreate = await _personService.Create(personRequest);
            if (personToCreate == null)
            {
                _logger.LogError($"An error occured while creating {personToCreate}");
                return StatusCode(422);
            }
            return Created("", personToCreate);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditPerson([FromBody] PersonRequest personRequest, int id)
        {
            PersonResponse personResponse;

            var personToUpdate = _personService.GetByIdAsync(id);
            if (personToUpdate == null)
                return BadRequest("Sorry, Person Doesn't exist");

            personResponse = await _personService.ModifyAsync(personRequest, id);
            if (personResponse == null)
                return BadRequest("Failed to update person");

            return Ok(personResponse);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            bool isDeleted = await _personService.DeleteAsync(id);
            if (!isDeleted)
                return BadRequest("Failed to delete person");
            return Ok("Person deleted Successfully");
        }

    }
}
