namespace CorePoint.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(T entity, CancellationToken cancellationToken = default);
        Task<bool> CreateAsync(T entity, CancellationToken cancellationToken = default);

        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
