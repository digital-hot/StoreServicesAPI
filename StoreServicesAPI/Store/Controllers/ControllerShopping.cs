using Microsoft.AspNetCore.Mvc;

namespace StoreServicesAPI.Store.Controllers
{
    using StoreServicesAPI.Store.Data;
    using StoreServicesAPI.Store.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {

        private readonly StoreData LocalStoreData;

        public ShoppingController(StoreData storeData)
        {
            LocalStoreData = storeData;
        }

        [HttpPost("Order")]
        public ActionResult<Order> CreateShopping([FromBody] OrderRequest request)
        {
            // return Ok("Not implemented");
            if (request == null || !request.Items.Any())
                return BadRequest("Invalid Order request");

            var order = new Order
            {
                Date = DateTime.Now,
                ClientId = request.ClientId,
                TotalPrice = 0,
                OrderProducts = new List<OrderProducts>()
            };

            foreach (var item in request.Items)
            {
                order.TotalPrice += item.Quantity * item.Price;

                var orderProduct = new OrderProducts
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                order.OrderProducts.Add(orderProduct);
            }
            LocalStoreData.Orders.Add(order);
            LocalStoreData.SaveChanges();

            return Ok($"The order was created for the amount {order.TotalPrice:C}");
        }

        [HttpGet("LastCustomers/{days}")]
        public ActionResult<IEnumerable<CustomerPurchaseInfo>> GetLastCustomers(int days)
        {
            var cutoffDate = DateTime.Now.AddDays(-days);

            var customers = LocalStoreData.Orders
                .Where(order => order.Date >= cutoffDate)
                .GroupBy(order => order.ClientId) 
                .Select(group => new CustomerPurchaseInfo
                {
                    ClientId = group.Key,
                    FullName = group.FirstOrDefault().Client.FullName, 
                    LastPurchaseDate = group.Max(order => order.Date) 
                })
                .ToList();

            return Ok(customers);
        }

        
    }
}