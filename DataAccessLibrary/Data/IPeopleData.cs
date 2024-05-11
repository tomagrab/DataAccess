using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;

public interface IPeopleData
{
    Task InsertPerson(PersonModel person);
    Task<IEnumerable<PersonModel>> GetAllPeople();
    Task<PersonModel> GetPersonById(int id);
    Task UpdatePerson(PersonModel person);
    Task DeletePerson(int id);
}
