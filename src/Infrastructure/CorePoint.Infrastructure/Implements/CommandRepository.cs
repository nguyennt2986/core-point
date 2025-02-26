using System.Data;
using Dapper;

namespace CorePoint.Infrastructure;

public class CommandRepository<T> : ICommandRepository<T> where T : class
{
    private readonly int _timeout;
    private readonly IDbConnection _connection;

    public CommandRepository(DapperContext context)
    {
        _timeout = context.Timeout;
        _connection = context.CreateConnection();
    }

    public bool Create(DynamicParameters parameters, string storeName)
    {
        return _connection.Execute(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public async ValueTask<bool> CreateAsync(DynamicParameters parameters, string storeName,
        CancellationToken cancellationToken = default)
    {
        if (cancellationToken.IsCancellationRequested)
            return false;

        return await _connection.ExecuteAsync(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public bool Delete(DynamicParameters parameters, string storeName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(DynamicParameters parameters, string storeName,
        CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public bool Update(DynamicParameters parameters, string storeName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(DynamicParameters parameters, string storeName)
    {
        throw new NotImplementedException();
    }
}
