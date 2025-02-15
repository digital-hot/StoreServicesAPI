namespace StoreServicesAPI.Store.Models
{
    public class OrderProducts
    {
     public int Id { get; set; }

    // Вказує на покупку
    public int OrderId { get; set; }
    public Order Order { get; set; }

    // Вказує на продукт
    public int ProductId { get; set; }
    public Product Product { get; set; }

    // Кількість одиниць цього товару
    public int Quantity { get; set; }

    // Вартість за кількість одиниць
    public decimal TotalPrice => Product.Price * Quantity;
    }
}