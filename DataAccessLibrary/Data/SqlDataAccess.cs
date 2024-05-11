using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccessLibrary;

public class SqlDataAccess
{
    private readonly IConfiguration _configuration;
    public SqlDataAccess(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public async Task<IEnumerable<T>> LoadData<T, U>
    (
        string storedProcedure,
        U parameters,
        string connectionStringName = "Default"
    )
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>
        (
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure
        );

        return rows;
    }
    public async Task SaveData<T>
    (
        string storedProcedure,
        T parameters,
        string connectionStringName = "Default"
    )
    {
        string connectionString = _configuration.GetConnectionString(connectionStringName);

        using IDbConnection connection = new SqlConnection(connectionString);

        await connection.ExecuteAsync
        (
            storedProcedure,
            parameters,
            commandType: CommandType.StoredProcedure
        );
    }
}
