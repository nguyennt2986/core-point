using System.Data;
using Dapper;

namespace CorePoint.Infrastructure;

public class DapperCommandRepository<T> : ICommandRepository<T> where T : class
{
    private readonly int _timeout;
    private readonly IDbConnection _connection;

    public DapperCommandRepository(DapperContext context)
    {
        _timeout = context.Timeout;
        _connection = context.CreateConnection();
    }

    public bool Create(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return _connection.Execute(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public async ValueTask<bool> CreateAsync(T args, string storeName, CancellationToken cancellationToken = default)
    {
        var parameters = Helper.BuildParameters(args);
        return await _connection.ExecuteAsync(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public async ValueTask<bool> DeleteAsync(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return await _connection.ExecuteAsync(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }
    public bool Delete(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return _connection.Execute(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public bool Update(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return _connection.Execute(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }

    public async ValueTask<bool> UpdateAsync(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return await _connection.ExecuteAsync(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout) > 0;
    }
}
