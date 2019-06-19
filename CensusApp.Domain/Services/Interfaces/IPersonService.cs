using CensusApp.Domain.RequestModels;
using CensusApp.Domain.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CensusApp.Domain.Services.Interfaces
{
    public interface IPersonService
    {
        IList<PersonResponse> GetAll();
        Task<PersonResponse> GetByIdAsync(int id);
        IList<PersonResponse> GetByGender(string gender);
        IList<PersonResponse> GetByStateOfOrigin(string state);
        IList<PersonResponse> GetByOccupation(string occupation);

        Task<PersonResponse> Create(PersonRequest person);
        Task<PersonResponse> ModifyAsync(PersonRequest person, int id);
        Task<bool> DeleteAsync(int uniqueIdentifier);
    }
}
