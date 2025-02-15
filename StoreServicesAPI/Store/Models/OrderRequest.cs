
namespace StoreServicesAPI.Store.Models
{
    public class OrderRequest
    {
        public int ClientId { get; set; } 
        public List<OrderItemRequest> Items { get; set; }
    }

    public class OrderItemRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Ціна на момент покупки
    }
}