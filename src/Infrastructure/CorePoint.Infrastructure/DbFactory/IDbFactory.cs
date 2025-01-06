namespace CorePoint.Infrastructure;

public interface IDbFactory<T> where T : class
{
    ICommandRepository<T> CommandRepository { get; }
    IQueryRepository<T> QueryRepository { get; }
}
