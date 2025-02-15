namespace StoreServicesAPI.Store.Models
{
    using System.Collections.Generic;
    public class Order
    {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public decimal TotalPrice { get; set; }

    // Колекція для зв'язку з товарними позиціями
    public ICollection<OrderProducts> OrderProducts { get; set; }
    }
}