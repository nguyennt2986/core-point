using System.Data;
using Microsoft.Data.SqlClient;

namespace CorePoint.Infrastructure;

public class DapperContext : IDbConnectionFactory
{
    private readonly string _connection;

    public DapperContext(string connection)
    {
        if (string.IsNullOrWhiteSpace(connection))
        {
            throw new ArgumentNullException(nameof(connection));
        }

        _connection = connection;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connection);
    }
}
