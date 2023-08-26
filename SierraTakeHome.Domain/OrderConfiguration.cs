using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SierraTakeHome.Domain
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.InsertUsingStoredProcedure("Order_Insert", storedProcedureBuilder => { 
                storedProcedureBuilder.HasParameter(o => o.CustomerId);
                storedProcedureBuilder.HasParameter(o => o.ProductId);
                storedProcedureBuilder.HasParameter(o => o.Quantity);
                storedProcedureBuilder.HasResultColumn(o => o.Id);
            });
        }
    }
}