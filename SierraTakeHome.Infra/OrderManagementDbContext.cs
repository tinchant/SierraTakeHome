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
            modelBuilder.Entity<Order>()
                .Property(order => order.TotalCost).ValueGeneratedOnAdd().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);
            modelBuilder.Entity<Order>()
                .InsertUsingStoredProcedure(
                "Order_Insert",
                builder =>
                {
                    builder.HasParameter(order => order.CustomerId);
                    builder.HasParameter(order => order.ProductId);
                    builder.HasParameter(order => order.Quantity);
                    builder.HasResultColumn(order => order.TotalCost);
                    builder.HasResultColumn(order => order.Id);
                });
        }
    }
}
