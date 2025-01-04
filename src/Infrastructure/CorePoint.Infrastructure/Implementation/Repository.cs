using System.Data;

namespace CorePoint.Infrastructure;

public class Repository<T> : ICommandRepository<T> where T : class
{
    private readonly IDbConnection _connection;

    public Repository(IDbConnection connection)
    {
        _connection = connection;
    }
    public bool Create(T entity)
    {
        // nên truen dynamic parameters
    }

    public bool Create(T entity, string storeName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> CreateAsync(T entity, string storeName, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public bool Delete(T entity)
    {
        throw new NotImplementedException();
    }

    public bool Delete(T entity, string storeName)
    {
        throw new NotImplementedException();
    }

    public bool Delete<TType>(TType id, string storeName)
    {
        throw new NotImplementedException();
    }

    public bool Delete<TType>(TType id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync(T entity, string storeName, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync<TType>(TType id, string storeName, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> DeleteAsync<TType>(TType id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
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

    public bool Update(T entity, string storeName)
    {
        throw new NotImplementedException();
    }

    public bool Update(T entity)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(T entity, string storeName)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
