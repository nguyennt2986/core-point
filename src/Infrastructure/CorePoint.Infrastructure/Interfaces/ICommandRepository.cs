using Dapper;

namespace CorePoint.Infrastructure;

public interface ICommandRepository<T> where T : class
{
    ValueTask<bool> CreateAsync(DynamicParameters parameters, string storeName,
        CancellationToken cancellationToken = default);
    bool Create(DynamicParameters parameters, string storeName);

    ValueTask<bool> UpdateAsync(DynamicParameters parameters, string storeName);
    bool Update(DynamicParameters parameters, string storeName);

    ValueTask<bool> DeleteAsync(DynamicParameters parameters, string storeName,
        CancellationToken cancellationToken = default);
    bool Delete(DynamicParameters parameters, string storeName);
}
