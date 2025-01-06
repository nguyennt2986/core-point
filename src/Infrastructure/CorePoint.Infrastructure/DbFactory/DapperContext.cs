using Microsoft.Data.SqlClient;
using System.Data;

namespace CorePoint.Infrastructure;

public class DapperContext : IDbConnectionFactory
{
    private readonly DbConfiguration _configuration;

    public int Timeout { get; private set; }


    public DapperContext(DbConfiguration configuration)
    {
        if (string.IsNullOrWhiteSpace(configuration.ConnectionString))
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(nameof(configuration.ConnectionString));
        }

        _configuration = configuration;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_configuration.ConnectionString);
    }

}
