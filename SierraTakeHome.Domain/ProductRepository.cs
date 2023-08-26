namespace SierraTakeHome.Domain
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public ProductRepository(OrderManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }
    }
}
