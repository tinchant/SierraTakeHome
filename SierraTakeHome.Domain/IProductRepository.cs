namespace SierraTakeHome.Domain
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(int id);
    }
}
