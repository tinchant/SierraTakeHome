using Microsoft.EntityFrameworkCore;

namespace SierraTakeHome.Domain
{
    public class OrderManagementDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }


}
