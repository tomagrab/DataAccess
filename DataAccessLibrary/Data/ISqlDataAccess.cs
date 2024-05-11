namespace DataAccessLibrary.Data;

public interface ISqlDataAccess
{
    Task<IEnumerable<T>> LoadDataAsync<T, U>(string sql, U parameters, string connectionStringName);
    Task SaveDataAsync<T>(string sql, T parameters, string connectionStringName);
}
