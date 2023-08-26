using SierraTakeHome.Domain;

namespace SierraTakeHome.Infra
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public OrderRepository(OrderManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
        }
    }
}
