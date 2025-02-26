using System.Data;

namespace CorePoint.Infrastructure;

public class QueryRepository<T> : IQueryRepository<T> where T : class
{
    private readonly IDbConnection _connection;

    public QueryRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    public T Get<TType>(TType id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public ValueTask<IQueryable<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<T> GetAsync<TType>(TType id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
