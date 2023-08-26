namespace SierraTakeHome.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
    }
}