namespace CorePoint.Infrastructure;

public interface IQueryRepository<T> where T : class
{
    ValueTask<IEnumerable<TOutput>> QueryAsync<TOutput>(T args, string storeName,
        CancellationToken cancellationToken = default);
    IEnumerable<TOutput> Query<TOutput>(T args, string storeName);

    ValueTask<TOutput?> QuerySingleAsync<TOutput>(T args, string storeName,
        CancellationToken cancellationToken = default);
    TOutput? QuerySingleAsync<TOutput>(T args, string storeName);
}
