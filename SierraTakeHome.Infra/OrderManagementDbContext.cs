using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SierraTakeHome.Domain;

namespace SierraTakeHome.Infra
{
    public class OrderManagementDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public OrderManagementDbContext(DbContextOptions<OrderManagementDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(order => order.Price).HasPrecision(14,2);
            modelBuilder.Entity<Order>()
                .Property(order => order.TotalCost).HasPrecision(14, 2);
            modelBuilder.Entity<Order>()
                .InsertUsingStoredProcedure(
                "Order_Insert",
                builder =>
                {
                    builder.HasParameter(order => order.CustomerId);
                    builder.HasParameter(order => order.ProductId);
                    builder.HasParameter(order => order.Quantity);
                    builder.HasParameter(order => order.TotalCost);
                    builder.HasResultColumn(order => order.Id);
                });
        }
    }
}
