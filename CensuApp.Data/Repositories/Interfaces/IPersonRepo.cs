using CensusApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CensusApp.Data.Repositories.Interfaces
{
    public interface IPersonRepo
    {
        IList<Person> SellectAll();
        Task<Person> SellectByIdAsync(int id);
        IList<Person> SellectByGender(string gender);
        IList<Person> SellectByStateOfOrigin(string state);
        IList<Person> SellectByOccupation(string occupation);
       
        Task<Person> Insert(Person person);
        Task<Person> UpdateAsync(Person person);
        Task<int> DeleteAsync(Person person);

    }
}
