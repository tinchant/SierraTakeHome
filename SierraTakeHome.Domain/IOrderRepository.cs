namespace SierraTakeHome.Domain
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
    }
}
