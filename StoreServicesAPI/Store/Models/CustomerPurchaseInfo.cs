
namespace StoreServicesAPI.Store.Models
{
    public class CustomerPurchaseInfo
    {
        public int ClientId { get; set; }
        public string FullName { get; set; }
        public DateTime LastPurchaseDate { get; set; }
    }
}