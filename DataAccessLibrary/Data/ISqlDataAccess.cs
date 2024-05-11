namespace DataAccessLibrary;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadData<T, U>(string sql, U parameters, string connectionStringName);
    Task SaveData<T>(string sql, T parameters, string connectionStringName);
}
