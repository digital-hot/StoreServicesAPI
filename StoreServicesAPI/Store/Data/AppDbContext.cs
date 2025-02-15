using Microsoft.EntityFrameworkCore;
using StoreServicesAPI.Store.Models;

namespace StoreServicesAPI.Store.Data
{
    public class StoreData : DbContext
    {
        public StoreData(DbContextOptions<StoreData> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
    }
}