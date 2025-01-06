namespace CorePoint.Infrastructure;

internal class DbFactory<T> : IDbFactory<T> where T : class
{
    public ICommandRepository<T> CommandRepository { get; private set; }

    public IQueryRepository<T> QueryRepository { get; private set; }


    public DbFactory()
    {

    }
}
