using System.ComponentModel.DataAnnotations;

namespace SierraTakeHome.Domain
{
    public class NewOrder
    {
        public int CustomerId { get; set; }
        [ExistingProductSpecification]
        public int ProductId { get; set; }
        [Range(1,int.MaxValue)]
        public int Quantity { get; set; }
    }
}