namespace CorePoint.Infrastructure;

public interface IQueryRepository<T> where T : class
{
    ValueTask<IQueryable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    ValueTask<T> GetAsync<TType>(TType id, CancellationToken cancellationToken = default);
    IQueryable<T> GetAll();
    T Get<TType>(TType id);
}
