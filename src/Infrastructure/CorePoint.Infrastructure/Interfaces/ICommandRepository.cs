namespace CorePoint.Infrastructure;

public interface ICommandRepository<T> where T : class
{
    ValueTask<bool> CreateAsync(T args, string storeName,
        CancellationToken cancellationToken = default);
    bool Create(T args, string storeName);

    ValueTask<bool> UpdateAsync(T args, string storeName);
    bool Update(T args, string storeName);

    ValueTask<bool> DeleteAsync(T args, string storeName);
    bool Delete(T args, string storeName);
}
