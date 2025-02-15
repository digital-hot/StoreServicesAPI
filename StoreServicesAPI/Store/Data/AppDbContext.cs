using Microsoft.EntityFrameworkCore;
using StoreServicesAPI.Store.Models;

namespace StoreServicesAPI.Store.Data
{
    public class StoreData : DbContext
    {
        public StoreData(DbContextOptions<StoreData> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

    }
}