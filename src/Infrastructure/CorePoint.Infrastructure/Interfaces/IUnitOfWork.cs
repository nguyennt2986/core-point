namespace CorePoint.Infrastructure
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void RollBack();
    }
}
