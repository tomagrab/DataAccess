namespace DataAccessLibrary.Modals;

public class PeopleData : IPeopleData
{
    private readonly ISqlDataAccess _sql;
    public PeopleData(ISqlDataAccess sql)
    {
        _sql = sql;
    }
    public async Task<IEnumerable<PersonModel>> GetAllPeople()
    {
        var people = await _sql.LoadDataAsync<PersonModel, dynamic>
        (
            "dbo.spPeople_GetAll",
            new { },
            "Default"
        );

        return people;
    }
    public async Task UpdatePerson(PersonModel person)
    {
        await _sql.SaveDataAsync
        (
            "dbo.spPeople_Update",
            person,
            "Default"
        );
    }
    public async Task InsertPerson(PersonModel person)
    {
        await _sql.SaveDataAsync
        (
            "dbo.spPeople_Insert",
            new
            {
                person.FirstName,
                person.LastName
            },
            "Default"
        );
    }
    public async Task DeletePerson(int id)
    {
        await _sql.SaveDataAsync
        (
            "dbo.spPeople_Delete",
            new { Id = id },
            "Default"
        );
    }
}
