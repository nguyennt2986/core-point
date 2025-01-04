namespace CorePoint.Infrastructure;

public interface ICommandRepository<T> where T : class
{
    ValueTask<bool> CreateAsync(T entity, CancellationToken cancellationToken = default);
    ValueTask<bool> CreateAsync(T entity, string storeName, CancellationToken cancellationToken = default);
    bool Create(T entity);
    bool Create(T entity, string storeName);


    ValueTask<bool> UpdateAsync(T entity, string storeName);
    ValueTask<bool> UpdateAsync(T entity);
    bool Update(T entity, string storeName);
    bool Update(T entity);

    ValueTask<bool> DeleteAsync(T entity, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteAsync(T entity, string storeName, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteAsync<TType>(TType id, string storeName, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteAsync<TType>(TType id, CancellationToken cancellationToken = default);
    bool Delete(T entity);
    bool Delete(T entity, string storeName);
    bool Delete<TType>(TType id, string storeName);
    bool Delete<TType>(TType id);
}
