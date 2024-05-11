﻿namespace DataAccessLibrary.Modals;

public interface IPeopleData
{
    Task DeletePerson(int id);
    Task<IEnumerable<PersonModel>> GetAllPeople();
    Task InsertPerson(PersonModel person);
    Task UpdatePerson(PersonModel person);
}
