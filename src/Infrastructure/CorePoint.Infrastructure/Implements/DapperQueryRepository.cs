using System.Data;
using Dapper;

namespace CorePoint.Infrastructure;

internal class DapperQueryRepository<T> : IQueryRepository<T> where T : class
{
    private readonly int _timeout;
    private readonly IDbConnection _connection;

    public DapperQueryRepository(DapperContext context)
    {
        _timeout = context.Timeout;
        _connection = context.CreateConnection();
    }

    public IEnumerable<TOutput> Query<TOutput>(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return _connection.Query<TOutput>(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout);
    }

    public async ValueTask<IEnumerable<TOutput>> QueryAsync<TOutput>(T args, string storeName, CancellationToken cancellationToken = default)
    {
        var parameters = Helper.BuildParameters(args);
        return await _connection.QueryAsync<TOutput>(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout);
    }

    public async ValueTask<TOutput?> QuerySingleAsync<TOutput>(T args, string storeName, CancellationToken cancellationToken = default)
    {
        var parameters = Helper.BuildParameters(args);
        return await _connection.QuerySingleOrDefaultAsync<TOutput>(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout);
    }

    public TOutput? QuerySingleAsync<TOutput>(T args, string storeName)
    {
        var parameters = Helper.BuildParameters(args);
        return _connection.QuerySingleOrDefault<TOutput>(storeName,
            parameters,
            commandType: CommandType.StoredProcedure,
            commandTimeout: _timeout);
    }
}
