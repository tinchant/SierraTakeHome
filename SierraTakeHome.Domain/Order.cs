

namespace SierraTakeHome.Domain
{
    
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; } //Would be better to have a list of products
        public int Quantity { get; set; }
        public decimal TotalCost { get; set; }

        protected Order()
        {
            
        }

        public Order(NewOrder newOrder)
            : this()
        {
            CustomerId = newOrder.CustomerId;
            ProductId = newOrder.ProductId;
            Quantity = newOrder.Quantity;   
        }
    }
}