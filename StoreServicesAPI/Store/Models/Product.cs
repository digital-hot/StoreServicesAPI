namespace StoreServicesAPI.Store.Models
{
    using System.Collections.Generic;
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ArticleNumber { get; set; }
        public decimal Price { get; set; }

        // Колекція для зв'язку з покупками
        public ICollection<OrderProducts> OrderProducts { get; set; }
    }
}